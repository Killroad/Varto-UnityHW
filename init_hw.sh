#!/bin/bash

# Ensure a homework name is provided
if [ -z "$1" ]; then
  echo "Usage: ./init_hw.sh 01"
  exit 1
fi

HW_NUM=$(printf "%02d" $1)
BRANCH_NAME="hw/$HW_NUM"
HW_DIR="Assets/HW$HW_NUM"

# Check if the script is run from the root of a Unity project
if [ ! -d "Assets" ] || [ ! -d "ProjectSettings" ]; then
  echo "❌ Error: This script must be run from the root of a Unity project."
  exit 1
fi

# Check if git branch already exists
if git show-ref --verify --quiet refs/heads/$BRANCH_NAME; then
  echo "❌ Branch $BRANCH_NAME already exists."
  exit 1
fi

# Create and switch to the new branch
git checkout -b $BRANCH_NAME || exit 1

# Create directory structure
mkdir -p "$HW_DIR/Art"
mkdir -p "$HW_DIR/Scenes"
mkdir -p "$HW_DIR/Scripts"
mkdir -p "$HW_DIR/Settings"

# Copy from Base, if exists
if [ -d "Assets/Base" ]; then
  echo "📁 Copying Base/ → HW$HW_NUM/"
  cp -r Assets/Base/* "$HW_DIR/" 2>/dev/null
fi

# Git stage and commit changes
git add "$HW_DIR"
git commit -m "Initialize HW$HW_NUM with base structure"

echo "✅ Branch $BRANCH_NAME initialized and committed!"

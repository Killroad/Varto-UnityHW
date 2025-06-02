# Varto Unity Homework

This repository contains Unity homework assignments organized in separate folders and branches.  
All homeworks are managed inside a **single Unity project**, each in its own subfolder under `Assets/`.

## 📁 Structure

```text
UnityHW/
├── Assets/
│   ├── Base/
│   │   └── ...
│   ├── HW01/
│   │   ├── Art/
│   │   ├── Scenes/
│   │   ├── Scripts/
│   │   └── Settings/
│   ├── HW02/
│   │   └── ...
│   └── ...
├── ProjectSettings/
├── Packages/
└── ...
```
Each homework is isolated in its own folder, containing only the assets related to that assignment.

## 🌿 Branching Strategy

Each homework is created on a separate Git branch:
- hw/01 
- hw/02 
- hw/03 
- etc.

The `master` branch contains the **initial Unity project setup only** and the `Assets/Base` folder, without any specific homework files.  
No merging into `master` is done unless explicitly needed - this helps avoid performance issues and keeps each task isolated.

## ✅ Progress

| Homework | Branch  | Folder         | Status    | Description                                                                                                                                                                                                                                                                                                                                       |
|----------|---------|----------------|-----------|---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| 01       | `hw/01` | `Assets/HW01/` | ✅ Done    | 1. Create a new Unity project with a scene named "HomeWork_01".<br/> 2. Add a controllable "Player" object with left/right movement (W/A/S/D keys) and an "Enemy" object that falls using physics.<br/> 3. Implement collision detection between them with a debug message.<br/> (Optional: auto-generate all objects and components via script.) |
| 02       | `hw/02` | `Assets/HW02/` | ⬜ Planned |                                                                                                                                                                                                                                                                                                                                                   |
| 03       | `hw/03` | `Assets/HW03/` | ⬜ Planned |                                                                                                                                                                                                                                                                                                                                                   |

## 🚀 Quick Start

To initialize a new homework:
```bash
./init_hw.sh 01
```

This will:
1. Create a new branch `hw/hw01`
2. Generate the folder `Assets/HW01` with subdirectories 
3. Commit the structure

## 📝 Notes
- All assets, scenes, and scripts related to a specific homework must be placed only inside its corresponding folder (e.g., `Assets/HW01/...`)
- Avoid mixing files from different assignments 
- Commit regularly on your feature branch (`hw/XX`)
- You can use `master` as a clean template base for future homework




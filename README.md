# 🎮 Tic-Tac-Toe AI Engine

A modern, feature-rich **Tic-Tac-Toe** game built with **C# and WinForms**. This project showcases a custom-built AI engine with three difficulty levels, a sleek user interface, and robust game logic.

---

## 🚀 Features

* **🧠 Advanced AI Opponent:** Play against a smart computer with 3 difficulty levels:
    * **Easy:** Random moves for a relaxed game.
    * **Medium:** The AI starts blocking your winning paths.
    * **Hard:** A strategic engine that plays both offensively and defensively.
* **👥 Player vs Player:** Challenge your friends in local multiplayer mode.
* **📊 Round System:** Customizable number of rounds with a real-time score tracker.
* **🎨 Modern UI/UX:** Clean, dark-themed design with intuitive controls and animations.
* **🎵 Interactive Sounds:** Immersive sound effects for moves, winning, and game starts.
* **⚙️ Smart Validation:** Prevents starting games without required info or difficulty selection.
  
---

## 📸 Screenshots

| Start | Setup Screen | Gameplay | End Game |
| :---: | :---: | :---: | :---: |
| ![Start](https://raw.githubusercontent.com/basant-fathy/Tic-Tac-Toe_Game/main/Screenshots/start.png) | ![Setup](https://raw.githubusercontent.com/basant-fathy/Tic-Tac-Toe_Game/main/Screenshots/setup.png) | ![Gameplay](https://raw.githubusercontent.com/basant-fathy/Tic-Tac-Toe_Game/main/Screenshots/gameplay.png) | ![End](https://raw.githubusercontent.com/basant-fathy/Tic-Tac-Toe_Game/main/Screenshots/end.png) |
---

## 🛠️ Tech Stack

* **Language:** C#
* **Framework:** .NET Framework / WinForms
* **Architecture:** Procedural with Logical Separation (AI vs UI Logic)
* **Assets:** Custom Graphic Assets & WAV Audio files

---

## 🧠 AI Logic Breakdown

The AI core uses a "Virtual Checker" method:
1.  **Defense:** It scans the board to see if the human player is about to win and blocks the path.
2.  **Offense:** In Hard mode, it prioritizes its own winning move before defending.
3.  **Efficiency:** It identifies available empty slots and processes moves without affecting the live UI colors until a decision is made.

---

## ⚙️ How to Run

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/basant-fathy/Tic-Tac-Toe_Game](https://github.com/basant-fathy/Tic-Tac-Toe_Game)
    ```
2.  Open the `.sln` file in **Visual Studio 2022**.
3.  Press **F5** to Build and Run.

*⚠️ Important (Windows Users)*

If you downloaded the project as a ZIP file and encountered build errors related to .resx files:
- Right-click any .resx file in project folder
- Select Properties
- Check Unblock
- Click Apply

---

## 👩‍💻 Developed By
**Bassant Fathy**
* [LinkedIn Profile](https://www.linkedin.com/in/bassant-fathy)
* [GitHub Profile](https://github.com/basant-fathy)

---
*If you liked this project, feel free to ⭐ the repository!*

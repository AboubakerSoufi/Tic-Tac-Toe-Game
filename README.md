 
# 🎮 Tic Tac Toe Game (XO Game)

A simple and interactive **Tic Tac Toe (X O)** desktop game built using **C# Windows Forms**.  
The game allows two players to compete locally on the same device with a clean UI and visual feedback.

---

---

## 🧩 Features

- 👥 Two-player mode (Player 1 vs Player 2)
- 🔄 Turn indicator (shows current player)
- 🏆 Winner detection system
- 🤝 Draw detection
- 🎨 Visual winning line highlight
- 🔁 Restart game button
- ❌ Prevents invalid moves
- 🖼️ Custom images for X and O
- 🎯 Simple and clean user interface

---

## 🛠️ Built With

- C#
- Windows Forms (.NET Framework)
- Visual Studio
- GDI+ Graphics (for drawing grid lines)

---

## 🧠 How the Game Works

- Each cell is a `PictureBox`
- Player 1 uses **X**, Player 2 uses **O**
- Each move updates the `Tag` property to track ownership
- The system checks all win combinations:
  - Rows
  - Columns
  - Diagonals
- If a player wins, the game stops automatically
- If all cells are filled → Draw

---

## ▶️ How to Run

1. Open the project in **Visual Studio**
2. Build the solution
3. Press **Start (F5)**
4. Enjoy the game 🎮

---

## 🔄 Restart Feature

Click the **"Restart Game"** button to:
- Reset the board
- Clear all images
- Reset turn to Player 1
- Re-enable all cells

---

## 📁 Project Structure

- `Form1.cs` → Game logic
- `Form1.Designer.cs` → UI design
- `Properties/Resources` → Images (X, O, question mark)

---

## 🚀 Future Improvements

- AI (Single Player Mode)
- Score system
- Sound effects
- Animations
- Online multiplayer

---
# 📸 Screenshot

![Tic-Tac-Toe-Game](Tic-Tac-Toe-Game/image/screenshot.png)

## 👨‍💻 Author

Developed by: **Soufi Aboubaker Seddik**

---

## 📜 License

This project is open-source and free to use for learning purposes.

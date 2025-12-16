# Smart Camping & Interactive Tents ⛺🌲

A comprehensive **Smart Camping Simulation** developed in **C# (Windows Forms)**. This application simulates the experience of setting up and managing a high-tech camping tent, requiring the user to make strategic decisions regarding location, equipment, energy management, and weather adaptation.

> **University Project**
> * **Course:** Human-Computer Interaction / Software Development
> * **Authors:** Georgios Ntokos (P21118), Ioannis Balkouras (P21228)

## 🎯 Project Goal
The goal of this application is to provide an interactive educational environment where users simulate the complete lifecycle of a camping setup. It emphasizes **interactivity** (Drag & Drop, TrackBars) and **decision-making** based on environmental variables.

## 🚀 Key Features

### 1. Tent Setup & Configuration 🔨
* **Location Selection:** Choose from 3 different sites based on stability, humidity, and shade parameters.
* **Pegs Adjustment:** Interactive configuration of tent peg angle and pressure using TrackBars to ensure stability.
* **Weather Protection:** Dynamic weather generation (Wind/Rain). Users must drag & drop the correct shades/covers to protect the tent using custom `System.Drawing` graphics.

### 2. Smart Systems Management 💡
* **Smart Lighting:** Adjust lighting intensity and color based on time of day (e.g., Night Mode) and ambient conditions.
* **Energy Management:** Monitor battery levels, power consumption, and solar efficiency. Users must prioritize devices to save power.

### 3. Services & Extras 🗺️
* **Navigation:** Route planning to safe shelters based on weather severity.
* **Tourism & Events:** Interactive maps for points of interest and event registration.
* **Ordering System:** Virtual interface for ordering food or coffee.
* **Live Chat:** Support interface simulation.

### 4. Summary System 📊
* **Final Report:** At the end of the simulation, a `SummaryForm` aggregates all user choices (location, energy saved, shelter chosen) to provide feedback on the camping strategy.

## 🛠️ Technical Stack

* **Language:** C#
* **Framework:** .NET Windows Forms (WinForms)
* **IDE:** Microsoft Visual Studio
* **Graphics:** `System.Drawing` for dynamic rendering.
* **Interaction:** Extensive use of Drag & Drop, TrackBars, PictureBoxes, and ComboBoxes.
* **Data Handling:** Runtime state management using static variables for seamless data flow between forms without an external database.



## 📦 How to Run

1.  **Clone** the repository.
2.  Open the `.sln` (Solution) file in **Microsoft Visual Studio**.
3.  **Build** the solution (Ctrl+Shift+B) to restore dependencies.
4.  Press **Start** to launch the simulation.

## 🔮 Future Enhancements
* Implementation of a persistent Database (SQL/SQLite) to save user sessions.
* Integration with a real-time Weather API.
* Enhanced navigation allowing users to return to previous steps for corrections.

---
*Developed for the University of Piraeus*

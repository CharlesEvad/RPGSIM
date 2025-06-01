# RPGSIM
RPGSIM - RPG Battle Simulator
=============================
MEMBERS: Jansean Calub, Jessie Lou Bugarin, Charles Dave Bugarin

This project is a simple Windows Forms RPG battle simulator that lets two players select their names and characters, then simulates a turn-based battle between them. The characters each have unique stats, by classic RPG classes.

---

Characters
----------

- **Charles (Fighter):**
  - High health, balanced attack.
  - Excels at close combat and has an advantage over Assassins.
- **Jansean (Marksman):**
  - Medium health, reliable ranged damage.
  - Has an advantage over Fighters.
- **JessieLou (Assassin):**
  - Lower health, but high burst damage.
  - Excels at taking down Marksman quickly.
- **Dex (Wizard):**
  - Lower health, powerful magic attacks.
  - Has an advantage over Marksman.

---

OOP Principles Applied
----------------------

1. **Encapsulation**
   - All character data (health, name, class) and methods (like `Attack`, `TakeDamage`) are encapsulated within the `Character` class and its subclasses.
   - The form handles all UI logic, keeping game logic separate.

2. **Abstraction**
   - `Character` is an abstract base class. It defines shared properties and the abstract `Attack()` method, which each subclass implements differently.
   - The UI abstracts the gameplay flow for the user.

3. **Inheritance**
   - Each specific character class (e.g., `Charles_Fighter`, `Jansean_Marksman`) inherits from `Character` and customizes its own stats and attack logic.

4. **Polymorphism**
   - The `Attack()` method is overridden in each subclass to provide unique damage calculation based on character type.
   - The game logic can handle characters generically, calling `Attack()` without knowing the specific class.

---

Challenges Faced
----------------

- **Designing the Class System:** Balancing the characters to make battles interesting and fair required several iterations of health and damage values.
- **OOP Structure:** Ensuring each OOP principle was clearly demonstrated while keeping the code simple and understandable.
- **Windows Forms Layout:** Arranging controls and updating the UI to reflect game state (health bars, battle logs, winner display) was occasionally tricky.
- **Event Handling:** Managing input events for changing character selections and starting battles, while avoiding bugs where UI elements might not update in sync.

---

Instructions to play
------------

1. Open the solution in Visual Studio.
2. Build and run the project.
3. Enter player names, select characters, then click "Start Battle" to watch the simulation.
4. The battle log will display turn-by-turn updates, and the winner will be shown at the end.

---

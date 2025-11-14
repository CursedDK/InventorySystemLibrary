# InventorySystemLibrary

A lightweight and flexible C# library for creating and managing inventory systems in games or applications. This library provides a simple, extensible framework that allows developers to define items, categories, and inventory logic with ease.

## Features
- Item creation with properties such as name, description, ID, and stack size.
- Inventory structure with add, remove, search, and stack management.
- Easy integration into game engines or other .NET applications.
- Fully open-source and customizable.

## Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/CursedDK/InventorySystemLibrary.git
   ```
2. Add the project to your solution.
3. Reference the library from your main project.

## Basic Usage
Prone to Change cuz this is kinda stupid! ¯\\\_(ツ)\_/¯
```csharp
Inventory = new Inventory(InventoryStyle.Default, InventoryType.Default);
var item = new Item("test", ItemRarity.Legendary, false, ItemGroup.Combat, ItemType.Weapon, [], 1);

inventory.AddItem(potion);
```

## Project Structure
- `Core/` — Core inventory logic
- `Helper/` — Helper classes

## Contributing
Pull requests are welcome! For major changes, open an issue first to discuss your ideas.
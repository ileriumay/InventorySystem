Project name: Inventory system
📝 Project Description:

This project is a Product inventory system developed using C# and SQLite. The project consists of four main interfaces that include listing, managing and user login validation of products:
	• Login Screen
	• Homepage (Main Menu)
	• Manage Items
	• List Items

Initially, SQL Server was used, but due to portability issues, it was switched to SQLite. The application can run on different computers and automatically creates a database if it is missing.

Key Features of the Project:
	• 🔑 Login Screen: You can log in with a specific username and password. A warning is given when incorrect information is entered, and the user is greeted when correct information is entered.
	• 📋 Item List: A screen where only the products are listed. Editing or adding cannot be done from this screen.
	• 🛠️ Item Management: Features of adding new products and editing existing products are provided.
	• 📂 Database Management: Using SQLite, the system automatically creates a new database if a suitable database does not exist.
	• 📝 Placeholder Support: When the empty boxes are not clicked, there are gray explanations, and when the user focuses on the box, the explanation disappears.
	• 🏠 Main Menu: You can switch between pages and exit the application.
	• 🧹 Code Optimization: Unnecessary codes were removed and explanatory comments were added for each section.
Technologies and Tools:
	• Programming Language: C#
	• Database: SQL Server → SQLite
	• Development Environment: Visual Studio
	• Other Tools: Git, YouTube resources, ChatGPT support
Installation instructions:
1. Download the Project
https://github.com/ileriumay/InventorySystem/new/master?filename=README.md
2. Run the Project
	• Open the project in Visual Studio.
	• Make sure the dependencies are installed correctly.

3. Database Control
	• If the SQLite database file does not exist, it will be created automatically when the application runs.
Instructions for Use

🔑 Login Screen
	• Username and Password: Access is provided by entering a specific username and password.
	• If incorrect information is entered, a warning message is displayed.

📋 Item List
	• Products are viewable only.
	• Editing or adding new products cannot be done from this screen.

🛠️ Item Management
	• Adding a New Product: Category, name, unit and quantity fields cannot be left blank. If left blank, a warning message will be shown.
	• Product Editing: Details of the selected product are displayed and can be edited in the textboxes below.
	• Placeholder Support: Empty areas have gray annotations that disappear when focused.

🏠 Main Menu
	• Transition between pages is provided.
	• The application is closed with the exit button.

📊 Database Management
	• In the first stage, SQL Server was used, then switched to SQLite due to portability problems.
	• If a suitable SQLite database file does not exist, the system creates it automatically
 
Supporting this project and sharing information:
Efe Küçük
Elif Canbeyli
Perihan Çelikoğlu
Umay İleri
Thank you to my teammates!

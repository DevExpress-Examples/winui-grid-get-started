using System;

namespace GridGetStarted {
    public static class DataGenerator {
        static Random rnd = new Random();
        static string[] Countries = new string[] {
            "Argentina", "Austria", "Belgium", "Brazil", "Canada", "Denmark", "Finland", "France", "Germany", "Ireland", "Italy", "Mexico", "Norway", "Poland", "Portugal", "Spain",
            "Sweden", "Switzerland", "UK", "USA", "Venezuela"};
        static string[] ProductNames = new string[] {
            "Alice Mutton", "Aniseed Syrup", "Boston Crab Meat", "Camembert Pierrot", "Carnarvon Tigers", "Chai", "Chang", "Chartreuse verte", "Chef Anton's Cajun Seasoning",
            "Chef Anton's Gumbo Mix", "Chocolade", "Côte de Blaye", "Escargots de Bourgogne", "Filo Mix", "Fløtemysost", "Geitost", "Genen Shouyu", "Gnocchi di nonna Alice",
            "Gorgonzola Telino", "Grandma's Boysenberry Spread", "Gravad lax", "Guaraná Fantástica", "Gudbrandsdalsost", "Gula Malacca", "Gumbär Gummibärchen", "Gustaf's Knäckebröd",
            "Ikura", "Inlagd Sill", "Ipoh Coffee", "Jack's New England Clam Chowder", "Konbu", "Lakkalikööri", "Laughing Lumberjack Lager", "Longlife Tofu",
            "Louisiana Fiery Hot Pepper Sauce", "Louisiana Hot Spiced Okra", "Manjimup Dried Apples", "Mascarpone Fabioli", "Maxilaku", "Mishi Kobe Niku", "Mozzarella di Giovanni",
            "Nord-Ost Matjeshering", "Northwoods Cranberry Sauce", "NuNuCa Nuß-Nougat-Creme", "Original Frankfurter grüne Soße", "Outback Lager", "Pâté chinois", "Pavlova",
            "Perth Pasties", "Queso Cabrales", "Queso Manchego La Pastora", "Raclette Courdavault", "Ravioli Angelo", "Rhönbräu Klosterbier", "Röd Kaviar", "Røgede sild",
            "Rössle Sauerkraut", "Sasquatch Ale", "Schoggi Schokolade", "Scottish Longbreads", "Singaporean Hokkien Fried Mee", "Sir Rodney's Marmalade", "Sir Rodney's Scones",
            "Sirop d'érable", "Spegesild", "Steeleye Stout", "Tarte au sucre", "Teatime Chocolate Biscuits", "Thüringer Rostbratwurst", "Tofu", "Tourtière", "Tunnbröd",
            "Uncle Bob's Organic Dried Pears", "Valkoinen suklaa", "Vegie-spread", "Wimmers gute Semmelknödel", "Zaanse koeken"};

        public static string GetProductName() {
            return ProductNames[rnd.Next(ProductNames.Length - 1)];
        }
        public static string GetCountry() {
            return Countries[rnd.Next(Countries.Length - 1)];
        }
        public static DateTime GetOrderDate() {
            DateTime date = new DateTime(2020, 1, 1);
            int range = (DateTime.Today - date).Days;
            return date.AddDays(rnd.Next(range));
        }
        public static double GetUnitPrice() {
            double price = rnd.Next(500, 10000);
            return price / 100;
        }
        public static int GetQuantity() {
            return rnd.Next(2, 60);
        }
    }
}

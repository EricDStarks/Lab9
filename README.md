# Lab9

The program will read the JSON data from the provided file path, deserialize it into a custom data structure, and perform the specified operations.

Description of Files:
Program.cs: This file contains the main entry point of the program and various methods to process the JSON data using LINQ queries.
JSON Data File
The program expects a JSON file named "Data.json" to be present at the location specified in the File.ReadAllText method within the Main method. Ensure that the file is properly formatted and contains valid JSON data.

Main Method:
The Main method is the entry point of the program. It reads the JSON data from the file, deserializes it into a FeatureCollection object, and then calls several methods to process the data using LINQ queries.

Methods:
Part1WithLINQ: This method groups the locations based on their neighborhood property and prints the count of locations in each neighborhood using LINQ query syntax.

Part2WithLINQ: This method filters out locations with an empty neighborhood property and prints the names of non-empty neighborhoods using LINQ query syntax.

Part3WithLINQ: This method performs the same operation as Part2WithLINQ, but using method syntax of LINQ.

Part4WithLINQ: This method is similar to Part3WithLINQ, but it uses method chaining to achieve the same result.

Part5WithLINQ: This method is a rewritten version of Part2WithLINQ, demonstrating the same functionality using method syntax instead of query syntax.

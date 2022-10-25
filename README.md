# Knowledge Check 2 for Software Course 1

1. Create a new Repsitory by clicking the green "Use this Template" button and setup a new repository in your account.
2. Create a new project in Visual Studio
3. Create a new object and then create another object that inherits from it.  Each object should have at least 1 property.  Example from the pet store: first class is Animal, second class is Cat and it inherits from Animal.
4. Paste the following template in the Program file:

```
Console.WriteLine("How many records do you want to add? ");
var numberOfRecords = int.Parse(Console.ReadLine());

var recordList = new List<MyClass>();
for (int i = 0; i < numberOfRecords; i++)
{
	// In this loop, populate the object's properties using Console.ReadLine()
	var myClass = new MyClass();

	Console.WriteLine("Enter the value for ");
	myClass. = Console.ReadLine();
    

	recordList.Add(myClass);
}

// Print out the list of records using Console.WriteLine()


```
 
5. Replace “MyClass” with the child class that you made in step 2.  
6. You should allow the user to add data for every property in your class.  So with the cat example, the user should be able to add values for every property of Cat which includes the properties from Animal.
7. Print the objects in recordList to the screen
8. Upload to the repository we created earlier on your Github account.
9. Turn in the knowledge check in Google Classroom. Make sure you include the link to your new GitHub repository when you "Turn In" the assignment.

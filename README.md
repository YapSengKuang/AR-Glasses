# AR-Glasses
FIT3170 Full Year project for AR Shopping List glasses

## Software required
- Unity: Development platform for creating the AR Application. 
- Android Studio: Integrated development environment (IDE) for Android app development and testing.
- XReal (Nreal) SDK : Software development kit for creating applications for the XReal (Nreal) AR Glasses.

## Hardware required
- Android Device : Can be used for testing 
- XReal (Nreal) AR Development Glasses : Primary hardware to run our AR Shopping List, application is only able to run on the development kit. 
- Windows/Mac Computer: A computer capable of running Unity. 

## How the Application Runs
### Getting the shopping list on the glasses
**Step 1 - creating the shopping list**
The application accesses a .csv file to manage your shopping list.
You can make this using excel and creating a 3 columns labelled "No.", "Item", "Quantity" Like this:
[image]
alternatively you can use a text editor and use commas "," to separate the columns
[image]
Ensure that the file is called MyShoppingList.csv

**Step 2 - putting the shopping list on the glasses**
First turn on the computing unit and connect it to your computer via a cable.
Then copy your shopping list over to the "LukAR" folder in internal storage.
When you're done it should look like this
[image]
Afterwards you can disconnect your computing unit from your computer

### How to use LukAR
When you open the application you will see a shopping list to your left.
[image]
if you do not see then then check that your .csv file has been correctly placed.
This shopping list can be minimised by clicking the top header
[image]
This shopping list will update whenever you confirm an item. But you can manually change this by pressing the checkbox to the right
[image]
When an item is checked, it will automatically be moved to the bottom of the shopping list and will not appear again to be checked.

LukAR will automatically detect items on your shopping list and will point out a single instance of that item to you
[image]
To collect that item, pick it up and move it close to the glasses, upon doing so you will see a confirmation popup
[image]
Use the pointer to click "yes" to mark it off the list or "no" if LukAR identified something wrong

## Additional Notes
- 

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

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147008473641537536/image.png)

alternatively you can use a text editor and use commas "," to separate the columns

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147008557716348998/image.png)

Ensure that the file is called MyShoppingList.csv

**Step 2 - putting the shopping list on the glasses**
First turn on the computing unit and connect it to your computer via a cable.
Then copy your shopping list over to the "LukAR" folder in internal storage.
When you're done it should look like this

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147021578916343900/image.png)
![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147021632053969016/image.png)

Afterwards you can disconnect your computing unit from your computer

### How to use LukAR
When you open the application you will see "My Shopping List" to your left.

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023132067102840/image.png)

You can click it with the pointer to expandup your shoppinglist 

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023034398543973/image.png)

Once open you can minimise it by clicking the "X"
Note: if you do not see your list then check that your .csv file has been correctly placed.

This shopping list will update whenever you confirm an item. But you can manually change this by pressing the checkbox to the right

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023283938672740/image.png)

When an item is checked, it will automatically be moved to the bottom of the shopping list and will not be detected again.

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023360077856820/image.png)

LukAR will automatically detect items on your shopping list and will point out a single instance of that item to you

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147023835007307907/image.png)

To collect that item, pick it up and move it close to the glasses, upon doing so you will see a confirmation popup

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147024012459909140/image.png)

Use the pointer to click "yes" to mark it off the list or "no" if LukAR identified something wrong

![image](https://cdn.discordapp.com/attachments/1080552633812664441/1147024133402673242/image.png)


## Additional Notes
- 

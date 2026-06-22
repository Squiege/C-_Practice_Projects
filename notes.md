<h1>Notes:</h1>

<h2>-Parsing Numbers-</h2>
C# wants to check if statements with true or false (bool), we can accomplish that with user input by parsing the data. We can use

bool booleanVariableName = int.TryParse(input, out int inputName); 

"booleanVariableName" will be our stored variable that we use to check if the parse has worked, if the parse does work it will hold the value of true.
If the parse does work it will hold the value of false. 

"int.TryParse" tells us we are trying to convert the input given to a integer ("int.") and we are going to attempt to parse it from a string to an integer("TryParse").

"(input, out int inputName);" is the value that we are trying to parse ("input"), sending out ("out") a integer ("int") stored in the variable of "inputName". 
If the parse is successful then the value will be stored as an integer from the given variable ("input"), if the parse fails then the value will be stored as 0.

We can call the sent variable ("inputName") without calling its parent ("booleanVariableName") to access the value we stored inside of it.

<h2> Loops </h2>
C# loops work similarly to the ones in python. Syntax for them goes as so

While Loops:
while ( condition )
{
    // Do stuff
}

For Loops:
for (start; condition; update)
{
    // do stuff
}

for (int i = 1; i <= 5; i++>)
{
    // do stuff
}

Foreach Loops:
foreach (string pointer in list)
{
    // do stuff
}


While loops are very straight forward, these loops will continue to loop until the condition is no longer met.

For loops will loop a specified number of times when the initial conditions remain true. 

Foreach loops allow us to use a pointer to point to each item within a list


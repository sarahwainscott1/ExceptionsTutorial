

//var num = 1;
//var den = 0;

//throwing custom exception message
/*if (den == 0) {
    var ex = new Exception("Denominator is zero; cannot divide by zero."); //creates custom message for the exception
    throw ex; //throws exception initialized above, this allows being more specific with the exception than the built in message
}
*/

/*//want to have code to deal with exception if they occur?
//works like if statement, if exception occurs with try block, will go through catch blocks
try { //if any exceptions in try block, will send an alert and give opportunity to fix it. try block says code within may cause error
    var ans = num / den;

}
catch (System.DivideByZeroException ex) {  //must use catch with try. must put exception after catch to act like if this ex occurs, do this. Must name variable for exception(ex)
    //can use variable ex to interrogate exception to see what data is in it, like CW(ex.Message) to write message to console
    Console.WriteLine(ex.Message); // doesn't cause fatal error, just pushes msg tried to divide by zero
}
catch (System.Exception ex) { //generic expetion if unsure exactly which one will be thrown. must be the last one in the list since it is generic, specific exceps must go first
    Console.WriteLine("There is an exception somewhere?");
}
finally { //when a catch block is executed, then the finally occurs
    Console.WriteLine("Finally");
}*/

A(); //call A, which calls B, which will have an exception. use try catch to surround b within a
Console.WriteLine("Done");
void A() {
    try {
        B();
    }
    catch (Exception ex) {
        Console.WriteLine(ex.Message);
    }
}
void B() {
    var num = 1;
    var den = 0;
    var c = num / den;
}

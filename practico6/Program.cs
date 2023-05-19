
bool isInteger;

do
{
    Console.WriteLine("Ingrese un numero entero : ");

    string input = Console.ReadLine();

    int number;

    isInteger = int.TryParse(input, out number); // isInteger is a  bool who confirmed if input is a word or not, if is a number, the value of input is save in the variable number

    if (isInteger == true)
    {

        while (number > 9)
        {

            Console.Write(number % 10);

            number = number / 10;


        }

        Console.Write(number);

    }
    else
    {

        Console.WriteLine("No ingreso un numero, intente nuevamente...");

    }

} while (isInteger == false);




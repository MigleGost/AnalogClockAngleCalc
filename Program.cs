
int hour = 12;
int minute = 00;
bool cont = true;

while(cont)
{        
    Console.WriteLine("Hello! This program is is used to calculate angle between analogue clock handles.");
    Console.WriteLine($"1.Enter hour value. Current value {hour} hours");
    Console.WriteLine($"2.Enter minute value. Current value {minute} minutes");
    Console.WriteLine($"3.Calculate lesser angle between clock handles");
    Console.WriteLine($"4.Exit");

    string menu = Console.ReadLine();

    switch (menu)
    {
        case "1":
            Console.WriteLine("Enter hour value: ");
            GetHours();
            break;
        case "2":
            Console.WriteLine("Enter minute value: ");
            GetMinutes();
            break;
        case "3":
            Console.WriteLine($"Angle is: {GetAngle(hour, minute)}");
            break;
        case "4":
            cont = false;
            break;
        default:
            Console.WriteLine("Please enter number 1-4 to execute command!");
            break;
    }

}

void GetHours()
{
    string input = Console.ReadLine();
    if(!Int32.TryParse(input, out hour))
    {
        Console.WriteLine("Wrong input! Please enter only numbers!");
    }
    else if(hour > 12 || hour < 1)
    {
        Console.WriteLine("Wrong value entered. Please enter values between 1 and 12.");
        hour = 12;
    }
}

void GetMinutes()
{
    string input = Console.ReadLine();
    if (!Int32.TryParse(input, out minute))
    {
        Console.WriteLine("Wrong input! Please enter only numbers!");
    }
    else if (minute > 60 || minute < 0)
    {
        Console.WriteLine("Wrong value entered. Please enter values between 0 and 60.");
    }
}

static int GetAngle(int hour, int minute)
{
    int angleH = (int)((hour * 60 + minute) * 0.5);
    int angleM = (int)(minute * 6);

    int angle = Math.Abs(angleH - angleM);
    angle = Math.Min(360 - angle, angle);

    return angle;
}

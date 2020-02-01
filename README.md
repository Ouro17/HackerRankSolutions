## Solutions for [HackerRank](https://www.hackerrank.com/).

Please, remember **not to cheat** and try to do the exercies by yourself before looking for a solution.

Hope you enjoy the solutions and if you want to add your solution doesn't hesitate to make a pull request.


## How can I add a solution

### C#
Go to the folder of the exercise you want to resolve and create a class that implements the interface:

```csharp
namespace HackerRank.InterviewPreparationKit.Arrays.TwoDArrayDS.Implementations
{
    public class TwoDArrayDSOuro17 : ITwoDArrayDS
    {
        public int HourglassSum(int[][] arr) 
        {
            // Your implementation here
        }

        // Add as many method as you need
    }
}
```

If your solution need more than one file, please add a folder with your name.

Next, add yourself to this problem Authors enum:

```csharp
public enum TwoDArrayDSAuthors
{
    Ouro17,
    //Your name here!
}
```

Finally, add your implementation class to the factory:

```csharp
switch (type)
{
    case TwoDArrayDSAuthors.Ouro17:
        return new TwoDArrayDSOuro17();
    case TwoDArrayDSAuthors.//YourNameEnum:
        return new //Your implementation();
    default:
        throw new NotSupportedException();
}
```

Now your code should run on the tests cases!!

Feel free to add more tests data and tests cases!

If you don't want other people tests cases to run, just comment it from the authors enum (Someone can improve this).

### Other languages
If you want to summit your solution in other language, create a folder and a project in that language and try to follow the logic behind the C# project so all the tests cases and implementation are automatic.

Then edit this README to teach people how to add solutions for this language!
using System;

class Cool {
    static void Main() {
        int temperature = 115;
        while (temperature > 112) {
            Console.WriteLine (temperature);
            temperature = temperature - 1;

        }
        Console.WriteLine ("The tea is cool enough");
    }
}
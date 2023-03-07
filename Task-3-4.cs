//// Task 3

//int num = 64;
//int check = 0;

//for (int i = 2; i <= num; i *= 2)
//{
//    check = i;
//}

//if (check < num)
//{
//    Console.WriteLine("2-nin quvveti deyildir");
//}
//else
//{
//    Console.WriteLine("2-nin quvvetidir");
//}



// Task 4

// Task 4

int num = 5118;
int first = 0;
int second = 0;
int save = 0;
while (num > 0)
{
    first = num % 10;
    num /= 10;
    second = num % 10;
    num /= 10;

    if (first > second && first > save)
    {
        save = first;
    }
}

Console.WriteLine(save);
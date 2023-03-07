// Task 3

int num = 64;
int check = 0;

for (int i = 2; i <= num; i *= 2)
{
    check = i;
}

if (check < num)
{
    Console.WriteLine("2-nin quvveti deyildir");
}
else
{
    Console.WriteLine("2-nin quvvetidir");
}
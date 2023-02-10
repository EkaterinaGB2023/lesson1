int dist = 10000; //distance
int ffs = 1; // first friend speed
int sfs = 2; //second friend speed
int ds = 5; // dog speed
int fr = 2; // direction of the dog from the first to the second
int time = 0; 

int count = 0;
while(dist > 10)
{
    if(fr == 1)
    {
    time = dist / (ffs + ds); fr = 2;
    }
    else
    {
    time = dist / (sfs + ds); fr = 1;
    }

dist = dist - (ffs + sfs) * time;
count++;
}

Console.Write("Собака пробежала ");
Console.Write(count);
Console.Write(" раз");
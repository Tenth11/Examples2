int[] array = {1, 42, 55, 64, 55, 6, 57, 68};

int n = array.Length;

int finde = 55;

int index = 0;

while(index < n){
    if(array[index] == finde)
    {Console.WriteLine(index);
    break;
    }
    index++;
}


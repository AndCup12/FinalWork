string[] array = new string[] {"f","f","d","dfgdsg","dsfg","ddf"};

int ReturnSizeNewArray(string[] arr){
    int size = 0;
    for (int i = 0; i < arr.Length; i++){
        if(arr[i].Length <= 3){
            size++;
        }
    }
    return size;
}

int size = ReturnSizeNewArray(array);
Console.WriteLine(size);

string[] createNewArray(int size, string[] arr){
    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < arr.Length; i++){
       if(arr[i].Length <= 3){
        newArray[count] = arr[i];
        count++;
       } 
    }
    return newArray;
}

void PrintArray(string[] arr){
    for (int i = 0; i < arr.Length; i++)
    {
        if(i == 0) Console.Write("[");
        if(i < arr.Length - 1) Console.Write(arr[i] + ",");
        else  Console.Write(arr[i] + "]");
    }
}
string[] newArray = createNewArray(size, array);
PrintArray(newArray);
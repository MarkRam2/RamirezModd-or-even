// mark ramirez
// 9/13/2022
//odd or even

Console.Clear();

long vnum;
bool num;
bool validation = true;
int idk = 0;
bool playing = true;

while(playing == true)
{

    Console.WriteLine("pick a number any number come on it's fun");


string input1 = "";
validation = true;
while(validation == true){
Console.WriteLine("enter a number");
input1 = Console.ReadLine();

    bool NuM1 = Int32.TryParse(input1, out idk);
    if(NuM1 == true ){
        validation = false;
    }else if(NuM1 == false){
    }
}



    num = Int64.TryParse(input1, out vnum);
    if (num == true)
    {
        if (vnum % 2 == 0)
        {
            Console.WriteLine("your number is even.");
        }
        else
        {
            Console.WriteLine("your Number is odd");
        }

    }

bool yessir = true;
Console.WriteLine("want to play again");
string responce = Console.ReadLine();
while(yessir == true)
{
responce.ToLower();
if(responce == "yes" ){
yessir = false;
playing = true;
}else if(responce == "no" ){
yessir = false;
playing = false;
}else{
Console.WriteLine($"so like i need a yes or no not this \"{responce}\" ");
responce = Console.ReadLine();
}
}
}

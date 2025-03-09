#include <iostream>
using namespace std;
int main()
{
cout << "Practica 5, Unidad 2 - Aaron" << "\n"; int num;
cout << "Escribe un numero " << "\n";
cin>>num;
if (num % 2 == 0) 
cout<<" EL NUMERO ES PAR"; 
else
if (num %3==0) cout<<" EL NUMERO ES IMPAR Y ES DIVISIBLE POR 3"; 
else cout<<"EL NUMERO ES IMPAR ES NO ES DIVISIBLE POR 3";
return 0;
}

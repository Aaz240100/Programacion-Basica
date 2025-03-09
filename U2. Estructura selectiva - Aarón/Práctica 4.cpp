#include <iostream>
using namespace std;
int main()
{
//Mensaje de Bienvenida
cout<<"Practica 4, Unidad 2 - Aaron" << "\n";
//Se declaran los números que se sumaran (pueden ser decimales) 
float SUELDO, aum, nsue;
//Se pide el primer numero
cout << "Por favor ingrese el sueldo: ";
//Se asigna el primer valor a SUELDO 
cin >> SUELDO;
if (SUELDO < 400000.00)
{
aum = SUELDO*0.15;
nsue = SUELDO + aum;
}
else
nsue=SUELDO*1.08;

cout << "El nuevo sueldo es: "<<nsue ; //Se muestra el resultado.
return 0;
}

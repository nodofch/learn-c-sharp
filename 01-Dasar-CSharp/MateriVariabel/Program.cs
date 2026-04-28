using System;

string namaKarakter = "Nodofch";
int healthPoint = 100;
float movementSpeed = 7.5f;
bool isAlive = true;

Console.WriteLine("=== STATUS HERO ===");
Console.WriteLine("Nama     : " + namaKarakter);
Console.WriteLine("Health   : " + healthPoint);
Console.WriteLine("Speed    : " + movementSpeed);
Console.WriteLine("Hidup    : " + isAlive);
Console.WriteLine("====================");

healthPoint = healthPoint - 20;
Console.WriteLine("\nTerkena Serangan! HP Sekarang: " + healthPoint);
using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia(numero: "123", modelo: "Model 1", imei: "111111", memoria:2 );
nokia.Ligar();
nokia.InstalarAplicativo("zap");

Console.WriteLine("/n");

Smartphone iphone = new Iphone(numero: "1223", modelo: "Model 13", imei: "1111111231" , memoria:2 );
iphone.ReceberLigacao();
iphone.InstalarAplicativo("monke");
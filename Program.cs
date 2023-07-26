using System;
using System.IO;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using monedas;

Console.WriteLine("Hello, World!");


var url = "https://api.coindesk.com/v1/bpi/currentprice.json";

WebClient wc = new WebClient();
var datos = wc.DownloadString(url);
mir rs = JsonSerializer.Deserialize<mir>(datos);

Console.WriteLine("Seleccione la moneda: ");
Console.WriteLine("(1) USD, precio: "+rs.bpi.USD.rate);
Console.WriteLine("(2) EUR, precio: "+rs.bpi.EUR.rate);
Console.WriteLine("(3) GBP, precio: "+rs.bpi.GBP.rate);
int opc = int.Parse(Console.ReadLine());

switch (opc)
{
    case 1:
    Console.WriteLine("-------USD-------");
    Console.WriteLine(rs.bpi.USD.description);
    Console.WriteLine("Simbolo: $");
    Console.WriteLine("Codigo: "+rs.bpi.USD.code);
    Console.WriteLine("rate: "+rs.bpi.USD.rate);
    Console.WriteLine("rate_float"+rs.bpi.USD.rate_float);
    break;
    case 2:
    Console.WriteLine("-------EUR-------");
    Console.WriteLine(rs.bpi.EUR.description);
    Console.WriteLine("Simbolo: €");
    Console.WriteLine("Codigo: "+rs.bpi.EUR.code);
    Console.WriteLine("rate: "+rs.bpi.EUR.rate);
    Console.WriteLine("rate_float"+rs.bpi.EUR.rate_float);
    break;
    case 3:
    Console.WriteLine("-------GBP-------");
    Console.WriteLine(rs.bpi.GBP.description);
    Console.WriteLine("Simbolo: £");
    Console.WriteLine("Codigo: "+rs.bpi.GBP.code);
    Console.WriteLine("rate: "+rs.bpi.GBP.rate);
    Console.WriteLine("rate_float: "+rs.bpi.GBP.rate_float);
    break;
}



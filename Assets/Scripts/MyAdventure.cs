using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;


public class MyAdventure : MonoBehaviour
{ 
    private enum States
    { 
        start,
        intro1,
        intro2,
        Startgesprek1,
        Startdeelja,
        Startdeelnee,
        leukgesprek,
        leukgesprek1,
        checksloten,
        slotja,
        slotnee,
        verstoppen,
        woonkamer,
        badkamer,
        slaapkamer,
        eindebad,
        eindewoonkamer,
        eindeslaapkamer,
        checkramen,
        zaklamp1,
        zaklamp2,
        pistool,
        politie,
        dood,
     
        


    } 
    private States currentState = States.start;




    // Start is called before the first frame update
    void Start()

    
    {
        
        Terminal.WriteLine("In De terminal");
        ShowMainMenu();

    }
void ShowMainMenu()
{
    Terminal.ClearScreen();
    Terminal.WriteLine("Welkom bij Horrornite");
    Terminal.WriteLine("Dit is gebaseerd op een waargebeurd verhaal");
    Terminal.WriteLine("Typ start om te beginnen");
}


void OnUserInput(string input)
{

if (currentState == States.start)
 
    if(input == "start")
    { 
        currentState = States.intro1;
        StartIntro1();
    }else if(input == "69")
    {
        Terminal.WriteLine("Dben je dom of doe je dom? is geen command"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }


   else if(currentState == States.intro1)


    if(input == "verder")
    { 
        currentState = States.intro2;
        StartIntro2();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    
    else if (currentState == States.intro2)

    if(input == "verder")
    { 
        currentState = States.Startgesprek1;
        Startgesprek1();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }


    else if (currentState == States.Startgesprek1)
    if(input == "ja")
    { 
        currentState = States.Startdeelja;
        Startdeelja();

    }else if(input == "nee")
    {
        currentState = States.Startdeelnee;
        Startdeelnee();   
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.Startdeelnee)
    if(input == "verder")
    { 
        currentState = States.leukgesprek;
        Startleukgesprek();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.Startdeelja)
    if(input == "verder")
    { 
        currentState = States.leukgesprek1;
        Startleukgesprek1();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

     else if (currentState == States.leukgesprek)
    if(input == "verder")
    { 
        currentState = States.checksloten;
        Startleukchecksloten();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

     else if (currentState == States.leukgesprek1)
    if(input == "verder")
    { 
        currentState = States.checksloten;
        Startleukchecksloten();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.checksloten)
    if(input == "ja")
    { 
        currentState = States.slotja;
        slotja();

    }else if(input == "nee")
    {
        currentState = States.slotnee;
        slotnee();   
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

     else if (currentState == States.slotja)
    if(input == "verder")
    { 
        currentState = States.slotja;
        verstoppen();
    }else if(input == "badkamer")
    {
        currentState = States.badkamer;
        badkamer(); 
    }else if(input == "woonkamer")
    {
        currentState = States.woonkamer;
        woonkamer(); 
    }else if(input == "slaapkamer")
    {
        currentState = States.slaapkamer;
        slaapkamer(); 
        
    }else
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
        Terminal.WriteLine("Dit is geen command");
    }

    
    else if (currentState == States.badkamer)
    if(input == "verder")
    { 
        currentState = States.eindebad;
        eindebad();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.woonkamer)
    if(input == "verder")
    { 
        currentState = States.eindewoonkamer;
        eindewoonkamer();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.slaapkamer)
    if(input == "verder")
    { 
        currentState = States.eindeslaapkamer;
        eindeslaapkamer();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.slotnee)
    if(input == "ja")
    { 
        currentState = States.checkramen;
        checkramen();

    }else if(input == "nee")
    {
        currentState = States.slotja;
        slotja();   
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.checkramen)
    if(input == "woonkamer")
    { 
        currentState = States.zaklamp1;
        zaklamp1();

    }else if(input == "slaapkamer")
    {
        currentState = States.zaklamp2;
        zaklamp2();   
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.zaklamp1)
    if(input == "verder")
    { 
        currentState = States.pistool;
        pistool();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.zaklamp2)
    if(input == "seinen naar buren")
    { 
        currentState = States.politie;
        politie();

    }else if(input == "onder bed verstoppen")
    {
        currentState = States.dood;
        dood();   
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.dood)
    if(input == "yusuf is de beste")
    { 
        currentState = States.start;
        ShowMainMenu();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.eindeslaapkamer)
    if(input == "yusuf is de beste")
    { 
        currentState = States.start;
        ShowMainMenu();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.eindebad)
    if(input == "yusuf is de beste")
    { 
        currentState = States.start;
        ShowMainMenu();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.eindewoonkamer)
    if(input == "yusuf is de beste")
    { 
        currentState = States.start;
        ShowMainMenu();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.politie)
    if(input == "yusuf is de beste")
    { 
        currentState = States.start;
        ShowMainMenu();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    else if (currentState == States.pistool)
    if(input == "yusuf is de beste")
    { 
        currentState = States.start;
        ShowMainMenu();
    }else if(input == "69")
    {
        Terminal.WriteLine("ben je dom of doe je dom?"); 
    }else
    {
        Terminal.WriteLine("Dit is geen command");
    }

    
    
    

    


  
void StartIntro1()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("Het was een koude donkere nacht");
    Terminal.WriteLine("Een heerlijke nacht om lekker fortnite te doen!");
    Terminal.WriteLine("Typ verder om door te gaan");
} 

void StartIntro2()
{
Terminal.ClearScreen();
    Terminal.WriteLine("je zit in een party met vrienden       te gamen");
    Terminal.WriteLine("er komt een vreemde in de party en je  vrienden leaven");
    Terminal.WriteLine("de party dus je zit samen met de       vreemde");
    Terminal.WriteLine("typ verder om door te gaan");

}

void Startgesprek1()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("de vreemde stuurt je een request om te chatten met je");
    Terminal.WriteLine("wil jij chatten met een vreemde");
    Terminal.WriteLine("ja of nee");
} 

void Startdeelja()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("jullie beginnen een leuk gesprek");
    Terminal.WriteLine("hij vraagt naar je gegevens om je beter te leren kennen");
    Terminal.WriteLine("typ verder om verder te gaan");
} 

void Startdeelnee()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("request komt toch binnen ");
    Terminal.WriteLine("en de vreemde vraagt naar je gegevens  om je beter te leren kennen");
    Terminal.WriteLine("typ verder om verder te gaan");
} 

void Startleukgesprek()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("jullie hebben een leuk gesprek en      begint de vreemde te vertrouwen ");
    Terminal.WriteLine("en geeft dus je adress gegevens aan de vreemde");
    Terminal.WriteLine("typ verder om verder te gaan");
} 

void Startleukgesprek1()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("jullie hebben een leuk gesprek ");
    Terminal.WriteLine("en vertrouwt de vreemde helemaal en    geeft je adress gegevens aan hem ");
    Terminal.WriteLine("om elkaar beter te leren kennen");
    Terminal.WriteLine("typ verder om verder te gaan");
} 

void Startleukchecksloten()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("het word al nacht  ");
    Terminal.WriteLine("dus je denkt eraan om de sloten  te");
    Terminal.WriteLine("checken doe je dit");
    Terminal.WriteLine("ja of nee");
} 

void slotja()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je ziet een vreemde door de  ramen naar binnen komen");
    Terminal.WriteLine("dus je rent door het huis");
    Terminal.WriteLine("typ verder om verder te gaan");
} 

void slotnee()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je denkt toch aan de ramen");
    Terminal.WriteLine("en denkt of je die beter kan checken   doe je dit ");
    Terminal.WriteLine("ja of nee");
} 

void verstoppen()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je denkt er aan om te verstoppen en    denkt aan");
    Terminal.WriteLine("woonkamer, badkamer en slaapkamer      welke kies je?");
} 

void badkamer()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je hebt gekozen voor badkamer");
    Terminal.WriteLine("je kiest eroor om te verstoppen in de  badkuip");
    Terminal.WriteLine("typ verder om verder te gaan!");
} 

void woonkamer()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je hebt gekozen voor woonkamer");
    Terminal.WriteLine("je kiest ervoor om te verstoppen achter de gordijnen");
    Terminal.WriteLine("typ verder om verder te gaan");
} 

void slaapkamer()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je hebt gekozen voor slaapkamer");
    Terminal.WriteLine("je kiest ervoor om onder het bed       te gaan");
    Terminal.WriteLine("typ verder om verder te gaan!");
} 

void eindebad()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("de vreemde denkt er niet aan om in de  badkamer te kijken ");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("je overleefd!");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("typ yusuf is de beste om de game       opnieuw te beginnen");
} 

void eindewoonkamer()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("de vreemde ziet je voeten wanneer hij  langs de woonkamer loopt ");
    Terminal.WriteLine("en wikkelt de gordijn om je nek en     wurgt je");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("je gaat dood!");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("typ yusuf is de beste om de game       opnieuw te beginnen");
} 

void eindeslaapkamer()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je ademde te hard uit spanning");
    Terminal.WriteLine("de vreemde hoorde je en trekt je onder jouw bed vandaan en snijd je keel open");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("je gaat dood!");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("typ yusuf is de beste om de game       opnieuw te beginnen");
} 

void checkramen()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("terwijl je bezig was met het checken   van de ramen valt de stroom uit");
    Terminal.WriteLine("dus je zoekt naar een zaklamp waar kijk je?");
    Terminal.WriteLine("woonkamer of slaapkamer");
    
}

void zaklamp1()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je hebt overal gekeken maar je vind    geen zaklamp");
    Terminal.WriteLine("typ verder om verder te gaan!");

    
    
}

void zaklamp2()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je bent gaan kijken in de kast in je   slaapkamer");
    Terminal.WriteLine("en vind daar een goed werkende zaklamp");
    Terminal.WriteLine("maar je hoort dat de vreemde een raam  door slaat!");
    Terminal.WriteLine("wat doe je?");
    Terminal.WriteLine("seinen naar buren of onder bed         vertoppen");
      
}

void pistool()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("doordat je niks ziet in het donker");
    Terminal.WriteLine("komt de vreemde stiekem ongezien achter je en breekt je nek");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("je gaat dood!");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("typ yusuf is de beste om de game       opnieuw te beginnen");
    
}

void politie()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("doordat je ging seinen naar de buren");
    Terminal.WriteLine("is de politie gekomen");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("je overleefd!");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("typ yusuf is de beste om de game       opnieuw te beginnen");
       
}

void dood()
{
 Terminal.ClearScreen();
    Terminal.WriteLine("je hebt er voor gekozen om te          verstoppen onder de bed");
    Terminal.WriteLine("de zaklamp die je had gevonden gaat    perongeluk aan");
    Terminal.WriteLine("de de vreemde ziet je en steekt je neer");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("je gaat dood!");
    Terminal.WriteLine("...........................");
    Terminal.WriteLine("typ yusuf is de beste om de game       opnieuw te beginnen");   
}





//Terminal.ClearScreen();
   // Terminal.WriteLine("");
   // Terminal.WriteLine("");
    //Terminal.WriteLine("");
    //Terminal.WriteLine("");
    //Terminal.WriteLine("");




    // Update is called once per frame

    void Update()
    {

    }
} }

    






















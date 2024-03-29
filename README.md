﻿# Human Benchmark - [Binary Release](https://drive.google.com/uc?export=download&id=1bAqK1KmjPTKmHkfNqZ1c8dFqvehiiE1G)
Windows Forms апликација изработена од Стефан Поцев 

---

## Опис на апликација
Апликацијата е имплементација од страната www.humanbenchmark.com, поточно игрите 
Reaction Time, Sequence Memory, Word Memory и Number Memory

Дополнително апликацијата автоматски зачувува максималните поени освоени за секоја игра

## Упатство за користење

Од главното мени се избира која игра корисникот сака да ја игра
![Main Menu](Images/Main_Menu.png)

### Reaction Time

Целта на играта е да се притисне со најмало време поминато при промената на панелот
од црвена во зелена боја.

По отварање на играта се пристигнува на следниот изглед
![Reaction Start](Images/Reaction_Start.png)

Со притискање на плавото се менува во следното
![Reaction Wait](Images/Reaction_Wait.png)

По поминато произволно време помеѓу 0.5 и 3 секунди се менува во следното
![Reaction Click](Images/Reaction_Click.png)

При притискање на зеленото се прикажува времето кое сте го добиле и се додава во 
минатите 5 времиња подоле, исто така се чива најголемото постигнато време во оваа 
сесија на играње, како и најдобро време постигнато досега и во предходни сесии
![Reaction Final](Images/Reaction_Final.png)

Со повторно притискање играта повторно почнува

### Sequence Memory
Целта на играта е да се запамти низата која се прикажува на играчот, и истата да 
се повтори.

Со започнување на играта се притистигнува на следниот изглед
![Sequence Start](Images/Sequence_Start.png)
Со притискање на копчето се покажува низата на играчот и после тој треба да ја 
повтори со притискање на квадратите
![Sequence Playing](Images/Sequence_Playing.png)
По направена грешка се покажува до кое ниво стигнал играчот и се овозможува пак 
да започне
![Sequence Final](Images/Sequence_Final.png)

### Word Memory
Целта на играта е да се одбере дали покажаниот збор бил предходно покажан

Со отварање на играта се пристигнува на следниот изглед
![Word Start](Images/Word_Start.png)
Со започнување се покажува збор и опции дали е нов или предходно бил покажан
![Word Playing](Images/Word_Playing.png)
По направена грешка се прикажува за колку зборови играчот одговорил точно
![Word Final](Images/Word_Final.png)

### Number Memory
Целта на играта е да се запамте прикажаниот број, со секој точен одговор се 
зголемува колку цифрен е бројот

Со отварање на играта се добива следниот изглед
![Number Start](Images/Number_Start.png)
Со започнување се прикажува бројот и одтекува време
![Number Reading](Images/Number_Reading.png)
По истекувањето на времето се чека играчот да го напише бројот
![Number Guessing](Images/Number_Guessing.png)
Се прикажува точниот број и бројот напишан од страна на играчот и ако тие се 
исти може да 
се продолжи понатаму, додека ако не се може да се започни од почеток
![Number Guessed](Images/Number_Guessed.png)

### Highscores
Се отвара со притискање на трофејот од главното мени и ги покажува најдобрите 
резултати постигнати од играчот.
До секој од резултатите има копче за тие да се избришат
![Highscores](Images/Highscores.png)

---

## Решение на проблемот

Секоја игра е направена во сопствена форма и се состои од сопствена логика.

### Reaction Time

За Reaction Time времињата се чуваат во класа ReactionTimeScores, потребен е 
еден Timer и еден Stopwatch за да може да функционира играта.
Со притискање се избира произволно време и се активира тајмерот, кога тајмерот 
ќе го помине времето се започнува stopwatch кој го мере времето потребно за играчот да 
притисне и тоа време се додава во објект од класата ReactionTimeScores

### Sequence Memory

За Sequence Memory се користи класата SequenceMemoryGame која чува листа која ја означува 
низата која играчот треба да ја повтори,  currNumber и currIndex кои означуваат до каде е 
стигнат играчот во низата, и две bool променливи Completed и Failed кои означуваат дали 
играчот стигнал до крајот на низата, и дали тој направил грешка соодветно.
```
public class SequenceMemoryGame
    {
        public List<int> OriginalSequence { get; set; }
        public int currNumber { get; set; }
        private int currIndex { get; set; }
        private Random random = new Random();
        public bool Completed { get; set; }
        public bool Failed {get; set; }
    }
```
Главна функција во оваа класа е playerGuess која прима број за влез кој означува кое 
копче е притиснато и проверува дали тоа копче е точно.
```
public void playerGuess(int guess)
        {
            if (currIndex < OriginalSequence.Count)
            {
                currNumber = OriginalSequence[currIndex];
                if (currNumber != guess)
                {
                    Failed = true;
                }
                if (currIndex == OriginalSequence.Count - 1)
                {
                    Completed = true;
                }
            }
            else
            {
                Completed = true;
                Failed = false;
            }
            currIndex++;
        }
```
### Word Memory

За Word Memory се користи класата WordMemoryGame која чува листа од зборови кои означуваат 
речник од кој играта влече зборови, и листа guessedWords која означува кои зборови
веќе се појавиле барем еднаш.
```
public class WordMemoryGame
    {
        public List<String> words { get; set; }
        public List<String> guessedWords { get; set; }
    }
```

Со започнување се зема произволен збор и се прикажува на екран. Со избирање на една од
опциите се проверува дали тој збор се појавил предходно и дали тоа се совпаѓа со одбереното
копче

### Number Memory

За Number Memory не се користи посебна класа, односно цела логика е во самата форма.
Во формата се чуваат променливи за моменталната состојба на играта, односно дали се прикажува
број, или внесуваме број, или во состојба на чекање.

Бројот се чува како String променлива за да дозволува многу поголем број на цифри.

---

Исто има имплементирано статичка класа Highscores во која се чуваат најдобрите освоени
резултати од секоја игра.

На секое затварање на главната форма вредностите од Highscores се запишуваат во Properties
својството на формата и со отварање на главната форма од истото се вчитуваат. 

Ова значи дека тие автоматски се зачувани и нема потреба од надворешни датотеки 
за зачувување.

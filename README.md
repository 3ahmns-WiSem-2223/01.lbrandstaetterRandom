# 01.lbrandstaetter-Random

## Warum könnte man den Zufall beim Programmieren brauchen?

1. Um Zufällige Zahlen zu generieren
2. Um zufällige Itemdrops bei z.B Gegnern in Spielen zu generieren
3. Um zufällige Farbcodes zu generieren


## Was ist der Unterschied zwischen Random aus System bzw. aus UnityEngine?

Zwischen UnityEngine und System.Random gibt es im wesentlichen nur 2 Unterschiede: 

## -Da UnityEngine.Random eine statische Klassse ist, hat man nur einen generator von Zuffalszahl pro Spiel. 

Bsp:

    System.Random beispielZufallsvariable;

## -Für System.Random muss man mindestens einen Instanziieren.

Bsp:

    int zufallsNummer = Random.Range(0, 50);


## Warum ist es sinnvoll den seed zu setzen bei Random?

Ein Seed ist der Ausgangspunkt für eine Folge von ausgedachten Zufallszahl in einem selbst bestimmten Zahlenbereich. Wenn Sie denselben Seed verwenden, erhalten Sie dieselbe Szene.

## Was macht Random.Range?

-Random.Range generiert eine Zufällige und begrenzte Zahl im eingegebenen eingegrenzten Bereich.

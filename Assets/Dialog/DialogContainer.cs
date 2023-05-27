using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogContainer
{
    public static int dialogTag = 1;

    public static readonly List<Actor> actors = new List<Actor>() {
        new Actor("Maradin", 0,0, true),
        new Actor("Neep Neep", 1,1),
        new Actor("LASER", 2,1),
        new Actor("?????", 3,1),
    };

    public static readonly List<DialogLine> singielDialog;

    public static List<List<DialogLine>> allDialogLines;

    public static List<List<DialogLine>> UtworzListeDialogow()
    {
        allDialogLines = new List<List<DialogLine>>();

        //main dialog
        allDialogLines.Add(new List<DialogLine>() {
        new DialogLine(actors[0], "At last! My incantation works!\r\n"),
        new DialogLine(actors[0], "Just one more line… And finally… I will no longer be…\r\n"),
        new DialogLine(actors[0], "Useless."),
        new DialogLine(actors[0], "Aeris sa’care et aeratenemer tan dorventi termen era sericca! " +
        "\r\n(A powerful warlock looks for a demon queen to rule the human realm by his side for all eternity. I like long walks through graveyards and late night listening to My Chemical Romance.)\r\n"),
        new DialogLine(actors[2], "*Laser sound*"),
        new DialogLine(actors[3], "WHO HAVE DARED TO SUMMON ME?"),
        new DialogLine(actors[0], "Oh great demon queen from the depths of the Vile Realm… Share your power with me!"),
        new DialogLine(actors[3], "FINALLY!\r\n"),
        new DialogLine(actors[3], "A powerful mage that will bring my name the glory I have yearned for!\r\n"),
        new DialogLine(actors[0], "Yeah!!!\r\n"),
        new DialogLine(actors[0], "So… what’s your plan, oh great demon queen?\r\n"),
        new DialogLine(actors[3], "My plan? You are the one who summoned ME!\r\n"),
        new DialogLine(actors[0], "Oh great demon queen? I’m afraid I’m but a humble servant of your… erm… demonity?\r\n"),
        new DialogLine(actors[3], "That’s not good…\r\n"),
        new DialogLine(actors[0], "Right! I’m pretty good at being evil. I mean bad. Bad at being evil. So I thought I could take some lessons from you… Borrow your powers and such… Hehe.\r\n"),
        new DialogLine(actors[1], "… Wrong number.\r\n"),
        new DialogLine(actors[0], "Why, on the Vile Realm, are you so tiny!?\r\n"),
        new DialogLine(actors[1], "That’s my line!\r\n"),
        new DialogLine(actors[0], "Oh my darkness, the incantation went wrong! You are not a demon queen! But a mere imp!\r\n"),
        new DialogLine(actors[0], "I have to start over… My power won’t be sufficient to cast the Final Spell without the help from the Vile Realm!"),
        new DialogLine(actors[1], "A mere imp!? Excuse me, mister “powerful warlock!” You weren’t honest in your summons at all!\r\n"),
        new DialogLine(actors[0], "What the…!? You catfished me! It was a spell for a super powerful being! I wanted a demon strong enough to carry me through the fights! And you… And you… You demon-fished me!\r\n"),
        new DialogLine(actors[1], "Oh please!"),
        new DialogLine(actors[0], "Oh please go back where you came from! I have no need for such a useless wisp!\r\n"),
        new DialogLine(actors[1], "*GASP* You didn’t…\r\n"),
        new DialogLine(actors[1], "Huh! Good luck with getting rid of me. \r\n"),
        new DialogLine(actors[0], "Huh!?"),
        new DialogLine(actors[1], "Such powerful summoning spell can’t be undone so easily. You are bound with me for the rest of your life!\r\n"),
        new DialogLine(actors[0], "You mean… like in a committed relationship!?"),
        new DialogLine(actors[0], "NOOOOOO!"),
        new DialogLine(actors[0], "Curse you! You little, useless… Wait a minute, wouldn’t you have to die with me if we are so strongly bound? As in “until death do us apart”…?"),
        new DialogLine(actors[1], "…Let’s break up."),
        new DialogLine(actors[0], "Of course! Finally some wise words have left that filthy mouth of yours."),
        new DialogLine(actors[0], "To the…! Eee… where are we going?"),
        new DialogLine(actors[1], "To the Adjourning Circle."),
        new DialogLine(actors[0], "To the Adjourning Circle!")
        });

        //podskok
        allDialogLines.Add(new List<DialogLine>()
        {
            new DialogLine(actors[1], "Oh darkness, you have to use your physical body. Pathetic!\r\n")
        });

        //Brama
        allDialogLines.Add(new List<DialogLine>()
        {
            new DialogLine(actors[0], "The evil has been defeated. There is no way I will get to that rune!"),
            new DialogLine(actors[1], "Ugh, what a weakling.")});

        //PO OTWORZENIU
        allDialogLines.Add(new List<DialogLine>()
        {
            new DialogLine(actors[0], "Not bad…\r\n"),
            new DialogLine(actors[1], "Hymph! Of course I’m not bad. I’m perfectly E V I L.\r\n")});

        //kolce
        allDialogLines.Add(new List<DialogLine>()
        {
            new DialogLine(actors[1], "What, on Vile Realm, is that!?\r\n"),
            new DialogLine(actors[0], "Oh, right. I used to practice magic around here. And that would be my last experiment… Hehe.\r\n"),
            new DialogLine(actors[1], "Ugh.")});

        //trap
        allDialogLines.Add(new List<DialogLine>()
        {
            new DialogLine(actors[0], "Aaaaa! I’m doomed! Goodbye pathetic word!\r\n"),
            new DialogLine(actors[1], "No dying till we break up!")});

        //PO O SHIELDOWANIU
        allDialogLines.Add(new List<DialogLine>()
        {
            new DialogLine(actors[0], "Ah! You call that a shield!? I got scratches all over my hat!\r\n"),
            new DialogLine(actors[1], "Get over yourself! No more shields for crybabies!\r\n"),
            new DialogLine(actors[0], "*Sniff* My hat…\r\n")});

        return allDialogLines;
    }

    
}

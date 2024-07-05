using System.Collections;
using TMPro;
using UnityEngine;
using YG;

public class ShowText : MonoBehaviour
{
    private int i;
    private string[] _phrasesDesc = { "Привет! Добро пожаловать в туториал! Начнём с перемещения. Используй клавиши AD для передвижения, ПРОБЕЛ для прыжка.",
                                  "Hi! Welcome to the tutorial! Let's start with moving. Use the AD keys to move, the SPACE to jump.",
                                  "Hallo! Willkommen im Tutorial! Beginnen wir mit dem Umzug. Verwenden Sie die AD-Tasten, um sich zu bewegen, die Leertaste, um zu springen.",
                                  "Merhaba! Eğitime hoş geldiniz! Hareket ederek başlayalım. Hareket etmek için AD tuşlarını, atlamak için boşluk çubuğunu kullanın.",
                                  "Смотри, это жук! Очень глупое и слабое создание, но всё-таки покусать способен. Можешь просто обойти, а можешь вступить в бой, нажимая ЛКМ! (Не забывай следить за показателем здоровья сверху слева)",
                                  "Look, it's a bug! A very stupid and weak creature, but still capable of biting. You can just go around, or you can join the battle by pressing the LMB! (Don't forget to keep an eye on the health indicator from the top left)",
                                  "Schau, das ist ein Käfer! Eine sehr dumme und schwache Kreatur, aber sie kann immer noch beißen. Du kannst einfach umgehen, oder du kannst in den Kampf treten, indem du die LMB drückst! (Vergiss nicht, den Gesundheitsindikator oben links zu überwachen)",
                                  "Bak, bu bir böcek! Çok aptalca ve zayıf bir yaratık, ama yine de ısırabilir. Sadece etrafından dolaşabilirsin ya da boyaya basarak savaşa girebilirsin! (Sağlığın göstergesini sol üstten izlemeyi unutmayın)",
                                  "Хм, неплохо... Вот и более сложный противник! Выносливее и сильнее. Используй своё огненное дыхание сочетанием Q+ЛКМ для атаки на расстоянии, но это потратит ману!",
                                  "Hmm, not bad... Here's a more difficult opponent! Tougher and stronger. Use your fire breath with a combination of Q+LMB to attack from a distance, but it will waste mana!",
                                  "Hmm, nicht schlecht... Das ist ein komplizierterer Gegner! Robuster und stärker. Benutze deinen feurigen Atem mit einer Kombination aus Q + LMB, um aus der Ferne anzugreifen, aber das wird Mana verschwenden!",
                                  "Hmm, fena değil... İşte daha zor rakip geliyor! Daha dayanıklı ve daha güçlü. Ateşli nefesinizi uzaktan saldırmak için Q + LMK kombinasyonuyla kullanın, ancak bu mana harcayacak!",
                                  "Последний боевой элемент - удар в прыжке. Довольно мощная атака, но если не добить противника, могут быть проблемы... Нажми ЛКМ+A/D во время прыжка.",
                                  "The last fight element is a jump shot. It's a pretty powerful attack, but if you don't finish off the enemy, there may be problems... Press LMB+A/D during the jump.",
                                  "Das letzte Schlagelement ist der Schlag im Sprung. Ein ziemlich starker Angriff, aber wenn Sie den Feind nicht beenden, kann es Probleme geben... Drücke während des Sprungs LMB + A / D.",
                                  "Son çarpma unsuru atlamada bir darbedir. Oldukça güçlü bir saldırı, ancak düşmanı bitirmezseniz sorunlar olabilir... Zıplarken LKM + A / D tuşlarına bas.",
                                  "Вот и всё. Должно быть у тебя осталось не так много здоровья и маны, а это значит, пришло время рассказать про бафы. Пройдись вперёд, может получится найти что-то интересное...",
                                  "That's all. You must not have much health and mana left, which means it's time to talk about buffs. Go ahead, maybe you can find something interesting...",
                                  "Das ist alles. Du musst nicht viel Gesundheit und Mana haben, was bedeutet, dass es an der Zeit ist, über Buffs zu sprechen. Gehen Sie voran, vielleicht finden Sie etwas Interessantes...",
                                  "Hepsi bu. Çok fazla sağlığınız ve mana kalmamış olmalısın, bu da baflardan bahsetmenin zamanı geldiği anlamına geliyor. Devam et, belki ilginç bir şey bulabilirsin..."
                                };

    private string[] _phrasesMob = { "Привет! Добро пожаловать в туториал! Начнём с перемещения. Используй стрелочки снизу для передвижения, ПРОБЕЛ для прыжка.",
                                     "Hello! Welcome to the tutorial! Let's start with moving. Use the arrows from the bottom to move, the SPACE bar to jump.",
                                     "Hallo! Willkommen im Tutorial! Beginnen wir mit dem Umzug. Verwenden Sie die Pfeile von unten, um sich zu bewegen, die Lücke, um zu springen.",
                                     "Merhaba! Eğitime hoş geldiniz! Hareket ederek başlayalım. Hareket etmek için aşağıdan okları, atlamak için boşluk çubuğunu kullanın.",
                                     "Смотри, это жук! Очень глупое и слабое создание, но всё-таки покусать способен. Можешь просто обойти, а можешь вступить в бой, нажимая на кулак! (Не забывай следить за показателем здоровья сверху слева)",
                                     "Look, it's a bug! A very stupid and weak creature, but still capable of biting. You can just walk around, or you can join the fight by pressing your fist! (Don't forget to keep an eye on the health indicator from the top left)",
                                     "Schau, das ist ein Käfer! Eine sehr dumme und schwache Kreatur, aber sie kann immer noch beißen. Du kannst dich einfach umdrehen, oder du kannst in den Kampf treten, indem du auf die Faust drückst! (Vergiss nicht, den Gesundheitsindikator oben links zu überwachen)",
                                     "Bak, bu bir böcek! Çok aptalca ve zayıf bir yaratık, ama yine de ısırabilir. Sadece etrafta dolaşabilirsin ya da yumruğuna basarak savaşa girebilirsin! (Sağlığın göstergesini sol üstten izlemeyi unutmayın)",
                                     "Хм, неплохо... Вот и более сложный противник! Выносливее и сильнее. Используй своё огненное дыхание, нажимая на огонь, для атаки на расстоянии, но это потратит ману!",
                                     "Hmm, not bad... Here's a more difficult opponent! Tougher and stronger. Use your fire breath by tapping on the fire to attack from a distance, but it will waste mana!",
                                     "Hmm, nicht schlecht... Das ist ein komplizierterer Gegner! Robuster und stärker. Benutze deinen feurigen Atem, indem du auf das Feuer drückst, um aus der Ferne anzugreifen, aber das wird Mana ausgeben!",
                                     "Hmm, fena değil... İşte daha zor rakip geliyor! Daha dayanıklı ve daha güçlü. Uzaktan saldırmak için ateşe basarken ateşli nefesini kullan, ama bu mana harcayacak!",
                                     "Последний боевой элемент - удар в прыжке. Довольно мощная атака, но если не добить противника, могут быть проблемы... Двигайся и ударь во время прыжка.",
                                     "The last combat element is a jump shot. It's a pretty powerful attack, but if you don't finish off the enemy, there may be problems... Move and hit while jumping.",
                                     "Das letzte Schlagelement ist der Schlag im Sprung. Ein ziemlich starker Angriff, aber wenn Sie den Feind nicht beenden, kann es Probleme geben... Bewegen Sie sich und schlagen Sie beim Sprung.",
                                     "Son savaş unsuru atlamada bir darbedir. Oldukça güçlü bir saldırı, ancak düşmanı bitirmezseniz sorunlar olabilir... Zıplarken hareket et ve vur.",
                                     "Вот и всё. Должно быть у тебя осталось не так много здоровья и маны, а это значит, пришло время рассказать про бафы. Пройдись вперёд, может получится найти что-то интересное...",
                                     "That's it. You must not have much health and mana left, which means it's time to talk about buffs. Go ahead, maybe you can find something interesting...",
                                     "Das ist alles. Du musst nicht viel Gesundheit und Mana haben, was bedeutet, dass es an der Zeit ist, über Buffs zu sprechen. Gehen Sie voran, vielleicht finden Sie etwas Interessantes...",
                                     "Hepsi bu. Çok fazla sağlığınız ve mana kalmamış olmalısın, bu da baflardan bahsetmenin zamanı geldiği anlamına geliyor. Devam et, belki ilginç bir şey bulabilirsin...",
                                   };

    public GameObject _panel;
    public string[] _messages;
    public TMP_Text _currentText;

    private void Awake() => i = YandexGame.savesData.usersLanguage;

    public void WriteText()
    {
        _currentText.text = "";
        StartCoroutine(TextAnimation());
        i += 4; //Кол-во языков
    }

    public IEnumerator TextAnimation()
    {
        if (YandexGame.savesData.device == 0)
        {
            foreach (var letter in _phrasesDesc[i])
            {
                _currentText.text += letter;
                yield return new WaitForSeconds(0.02f);
            }
        }
        
        else
        {
            foreach (var letter in _phrasesMob[i])
            {
                _currentText.text += letter;
                yield return new WaitForSeconds(0.02f);
            }
        }
    }

    public void ButtonOkCkick()
    {
         _panel.SetActive(false);
    }
}

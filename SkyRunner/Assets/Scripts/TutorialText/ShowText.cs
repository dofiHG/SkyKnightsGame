using System.Collections;
using TMPro;
using UnityEngine;

public class ShowText : MonoBehaviour
{
    private int i;
    private string[] _phrases = { "Привет! Добро пожаловать в туториал! Начнём с перемещения. Используй клавиши AD для передвижения, ПРОБЕЛ для прыжка.",
                                  "Hi! Welcome to the tutorial! Let's start with moving. Use the AD keys to move, the SPACE to jump.",
                                  "Смотри, это жук! Очень глупое и слабое создание, но всё-таки покусать способен. Можешь просто обойти, а можешь вступить в бой, нажимая ЛКМ! (Не забывай следить за показателем здоровья сверху слева)",
                                  "Look, it's a bug! A very stupid and weak creature, but still capable of biting. You can just go around, or you can join the battle by pressing the LMB! (Don't forget to keep an eye on the health indicator from the top left)",
                                  "Хм, неплохо... Вот и более сложный противник! Выносливее и сильнее. Используй своё огненное дыхание сочетанием Q+ЛКМ для атаки на расстоянии, но это потратит ману!",
                                  "Hmm, not bad... Here's a more difficult opponent! Tougher and stronger. Use your fire breath with a combination of Q+LMB to attack from a distance, but it will waste mana!",
                                  "Последний бевой элемент - удар в прыжке. Довольно мощная атака, но если не добить противника, могут быть проблемы... Нажми ЛКМ+A/D во время прыжка.",
                                  "The last fight element is a jump shot. It's a pretty powerful attack, but if you don't finish off the enemy, there may be problems... Press LMB+A/D during the jump.",
                                  "Вот и всё. Должно быть у тебя осталось не так много здоровья и маны, а это значит, пришло время рассказать про бафы. Пройдись вперёд, может получится найти что-то интересное...",
                                  "That's all. You must not have much health and mana left, which means it's time to talk about buffs. Go ahead, maybe you can find something interesting..." 
                                 };

    public GameObject _panel;
    public string[] _messages;
    public TMP_Text _currentText;

    private void Awake() => i = PlayerPrefs.GetInt("langInt");

    public void WriteText()
    {
        _currentText.text = "";
        StartCoroutine(TextAnimation());
        i += 2; //Кол-во языков
    }

    public IEnumerator TextAnimation()
    {
        foreach (var letter in _phrases[i])
        {
            _currentText.text += letter;
            yield return new WaitForSeconds(0.02f);
        }
    }

    public void ButtonOkCkick()
    {
         _panel.SetActive(false);
    }
}

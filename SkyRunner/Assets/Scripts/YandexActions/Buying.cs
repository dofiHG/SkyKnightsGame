using TMPro;
using UnityEngine;
using YG;

public class Buying : MonoBehaviour
{
    public GameObject _starAdvicePanel;
    public TMP_Text _mainText;

    private string[] _advicesRus = 
    {
        "Не стоит бояться упасть в начале пути...",
        "Подъём и возвращение укажут путь...",
        "Порой стоит отступить назад и выйти за пределы сознания...",
        "Опасное испытание уготовано летящим...",
        "Порой реальность тоньше, чем кажется, может можно её порвать?..",
        "Сноровка и труд всё превзойдут...",
        "Только упорный получит своё...",
        "Чтобы подняться нужно начала упасть...",
        "Стоит мыслить нелинейно...",
        "Сердцевина не так прочна, как кажется...",
        "Опасности сулят большую добычу, но осторожным тоже нужно быть...",
        "Даже при падение на бамбуковые шипы есть надежда на спасение",
        "Нащупывается что-то невидимое и твёрдое над медведем...",
        "Бессмысленно подниматься, когда есть прямая дорога",
        "4. что же это может значить?..",
        "Длинными руками дотянуться можно до рая, а можно и до ада...",
        "Иногда счастье нельзя увидеть, но можно почувствовать, а иногда кто-то его сторожит...",
        "Порой друзья предают, а враги предлагают мир...",
        "Повторенье - мать ученья",
        "Деревья - единственное что приносит покой в столь быстротечной жизни",
        "Нет ничего лучше того, что достаётся бесплатно",
        "Ловкие руки могут дом построить, хлеб испечь и даже звезду с неба достать",
        "Трудности закаляют",
        "Если что-то важное теряешь, стоит вернуться к моменту, когда всё было на месте",
        "Не все готовы рисковать, но кто не рисует, тот..."
    };

    private string[] _advicesEng =
    {
        "Do not be afraid to fall at the beginning of the path...",
        "Rising and returning will show the way ...",
        "Sometimes it is worth stepping back and going beyond consciousness ...",
        "A dangerous test is prepared for flying ...",
        "Sometimes reality is thinner than it seems, maybe you can break it?..",
        "Skill and work will surpass everything...",
        "Only the stubborn will get their way...",
        "To rise you need to start falling...",
        "It's worth thinking non-linearly...",
        "The core is not as strong as it seems...",
        "Dangers promise great prey, but you also need to be careful...",
        "Even when falling on bamboo spikes, there is hope of salvation",
        "Something invisible and solid is groping above the bear...",
        "It is pointless to climb when there is a straight road",
        "4. what can this mean?..",
        "With long arms you can reach heaven, or you can reach hell...",
        "Sometimes happiness cannot be seen, but you can feel it, and sometimes someone guards it...",
        "Sometimes friends betray, and enemies offer peace...",
        "Repetition is the mother of learning",
        "Trees are the only thing brings peace in such a fleeting life",
        "There is nothing better than what you get for free",
        "Clever hands can build a house, bake bread and even get a star from the sky",
        "Difficulties harden",
        "If you lose something important, it's worth going back to the moment when everything was in place",
        "Not everyone is willing to take risks, but those who don't draw don't drink"
    };

    private string[] _advicesGer =
    {
        "Hab keine Angst davor, am Anfang des Weges zu fallen...",
        "Der Aufstieg und die Rückkehr werden den Weg weisen...",
        "Manchmal lohnt es sich, sich zurückzuziehen und über das Bewusstsein hinauszugehen...",
        "Ein gefährlicher Test wird für die Fliegenden vorbereitet...",
        "Manchmal ist die Realität dünner, als es scheint, vielleicht kann man sie zerreißen?..",
        "Geschicklichkeit und Arbeit werden alles übertreffen...",
        "Nur der Hartnäckige wird sein eigenes bekommen...",
        "Um aufzusteigen, musst du anfangen zu fallen...",
        "Es lohnt sich, nichtlinear zu denken...",
        "Der Kern ist nicht so fest, wie er aussieht...",
        "Gefahren versprechen große Beute, aber Sie müssen auch vorsichtig sein...",
        "Selbst wenn Sie auf Bambusspitzen fallen, besteht Hoffnung auf Erlösung",
        "Etwas Unsichtbares und Festes wird über den Bären tastet...",
        "Es ist sinnlos, aufzusteigen, wenn es eine gerade Straße gibt",
        "4. was könnte das bedeuten?..",
        "Man kann mit langen Händen das Paradies erreichen, aber man kann auch die Hölle erreichen...",
        "Manchmal kann man Glück nicht sehen, aber man kann es fühlen, und manchmal wacht jemand darauf...",
        "Manchmal verraten Freunde, und Feinde bieten Frieden an...",
        "Wiederholung ist die Mutter der Lehre",
        "Bäume sind das einzige, was in einem so schnellen Leben Frieden bringt.",
        "Es gibt nichts Besseres als das, was man kostenlos bekommt.",
        "Geschickte Hände können ein Haus bauen, Brot backen und sogar einen Stern vom Himmel holen.",
        "Schwierigkeiten werden gemildert",
        "Wenn Sie etwas Wichtiges verlieren, sollten Sie zu dem Zeitpunkt zurückkehren, an dem alles vorhanden war.",
        "Nicht jeder ist bereit, Risiken einzugehen, aber wer nicht zeichnet, ist derjenige..."
    };

    private string[] _advicesTur =
    {
        "Yolculuğun başında düşmekten korkmamalısınız...",
        "Yükseliş ve dönüş yolu gösterecek...",
        "Bazen geri çekilmeye ve bilincin ötesine geçmeye değer...",
        "Uçanlar için tehlikeli bir sınav hazırlanmıştır...",
        "Bazen gerçeklik göründüğünden daha incedir, belki onu kırabiliriz?..",
        "Beceri ve emek her şeyi aşacak...",
        "Ancak inatçı olan kendi yolunu bulacaktır...",
        "Yükselmek için düşmeye başlamalısın...",
        "Doğrusal olmayan düşünmeye değer...",
        "Çekirdek göründüğü kadar güçlü değil...",
        "Tehlikeler büyük av vaat ediyor, ancak dikkatli olmanız da gerekiyor...",
        "Bambu dikenlere düşse bile kurtuluş umudu var",
        "Ayının üzerinde görünmez ve sağlam bir şey hissediliyor...",
        "Düz bir yol olduğunda tırmanmak anlamsızdır",
        "4. Peki bu ne anlama gelebilir?..",
        "Cennete uzun ellerle ulaşabilirsin, cehenneme de ulaşabilirsin...",
        "Bazen mutluluk görülemez ama hissedilebilir ve bazen biri onu korur...",
        "Bazen arkadaşlar ihanet eder ve düşmanlar barış teklif eder...",
        "Tekrarlama, öğrenmenin anasıdır",
        "Ağaçlar, böylesine geçici bir yaşamda huzuru getiren tek şeydir",
        "Bedavaya alınandan daha iyi bir şey yoktur",
        "Becerikli eller bir ev inşa edebilir, ekmek pişirebilir ve hatta gökten bir yıldız bile alabilir",
        "Zorluklar sertleşiyor",
        "Önemli bir şeyi kaybederseniz, her şeyin olduğu ana geri dönmelisiniz",
        "Herkes risk almaya hazır değil, ama resim yapmayan o..."
    };
 
    private void OnEnable() => YandexGame.PurchaseSuccessEvent += SuccessPurchased;

    private void OnDisable() => YandexGame.PurchaseSuccessEvent -= SuccessPurchased;

    public void SuccessPurchased(string id)
    {
        if (id == "1") { YandexGame.savesData.activeLvls += 1; }

        if (id == "2")
        {
            int starToOpen = 0;

            for (int i = 0; i < YandexGame.savesData.openedStars1.Length; i++)
                if (YandexGame.savesData.openedStars1[i] == 0) { starToOpen = i; break; }

            _starAdvicePanel.SetActive(true);
            Debug.Log(starToOpen);
            switch (YandexGame.savesData.usersLanguage)
            {
                case 0: _mainText.text = _advicesRus[starToOpen]; break;
                case 1: _mainText.text = _advicesEng[starToOpen]; break;
                case 2: _mainText.text = _advicesGer[starToOpen]; break;
                case 3: _mainText.text = _advicesTur[starToOpen]; break;
            }
        }

        if (id == "3")
        {
            for (int i = 0; i <= YandexGame.savesData.openedStars1.Length; i++)
            {
                if (YandexGame.savesData.openedStars1[i] == 0) { YandexGame.savesData.openedStars1[i] = 1; break; }
            }
        }

        YandexGame.SaveProgress();
    }
}

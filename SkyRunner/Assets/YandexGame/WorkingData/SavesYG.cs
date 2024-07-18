
namespace YG
{
    [System.Serializable]
    public class SavesYG
    {
        // "Технические сохранения" для работы плагина (Не удалять)
        public int idSave;
        public bool isFirstSession = true;
        public string language = "ru";
        public bool promptDone;
        // Ваши сохранения

        public int currentLvl;
        public int activeLvls = 1;
        public int usersLanguage = 0;
        public bool isPlusHp = false;
        public int IsPlaySound = 1;
        public bool activeTutorial;
        public int device = 0;
        public int adviceToOpen = -1;


        public int[] openedStars1 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    }
}

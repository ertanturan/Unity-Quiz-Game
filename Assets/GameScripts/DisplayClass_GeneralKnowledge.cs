using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayClass_GeneralKnowledge : MonoBehaviour
{

    public Text QuestionField;
    public Text OptionAField;
    public Text OptionBField;
    public Text OptionCField;
    public Text OptionDField;
    public Text QuestionCountText;
    public Text ScoreFieldText;

    public Button NextButton;
    public Button AButton;
    public Button BButton;
    public Button CButton;
    public Button DButton;

    public Button NextSceneButton;
    public Image transprentLayer;

    List<QuestionTemplate> Questions;

    public float ramdomNumber;
    public int QuestionCount = 0;

    public int TotalQuestionPerRound = 7;
    public int TotalQuestionsInDataBase = 92;

    void Start()
    {


        GameControl.control.TotalRounds = GameControl.control.TotalRounds + 1;
        NextSceneButton.gameObject.SetActive(false);
        transprentLayer.gameObject.SetActive(false);
        //NextButton.gameObject.SetActive(false);
        NextSceneButton.transform.parent.gameObject.SetActive(false);

        Questions = new List<QuestionTemplate>();

        Questions.Add(new QuestionTemplate(0, "Ayşe 32, Sema 28 yaşındadır. Ayşe Sema’dan kaç yaş büyüktür?",
            "4", "13", "14", "24", "4"));

        Questions.Add(new QuestionTemplate(1, "Kırdan 67 papatya topladım. Papatyalardan 13 tanesini anneme, 26 tanesini teyzeme verdim. Geri kalanını da vazoya koyduk. Vazoda kaç çiçek vardır?", "17", "28", "31", "28", "28"));

        Questions.Add(new QuestionTemplate(2, "78 sayfalık kitabın birinci gün 23, ikinci gün 36 sayfasını okudum. Geriye kaç sayfa kaldı?",
            "8", "19", "23", "36", "19"));

        Questions.Add(new QuestionTemplate(3, "64 sayfalık kitabın birinci gün 21 sayfasını okudum. İkinci gün ise birinci günden 8 sayfa eksik okudum. Geriye okunacak kaç sayfa kaldı?",
            "18", "30", "25", "26", "30"));

        Questions.Add(new QuestionTemplate(4, "6  düzine kalemin 9 eksiği kaçtır?",
            "43", "63", "33", "29", "63"));

        Questions.Add(new QuestionTemplate(5, "5 deste tebeşirden 13 tanesini kullandık. Geriye kaç tebeşir kaldı?",
            "23", "37", "44", "48", "37"));

        Questions.Add(new QuestionTemplate(6, "Bir otobüste 34 yolcu var. İlk durakta 23 yolcu indi, 19 yolcu bindi. İkinci durağa hareket eden otobüste kaç yolcu vardır?",
            "17", "23", "30", "38", "30"));

        Questions.Add(new QuestionTemplate(7, "Sınıfımızın mevcudu 37'dir. Bunun 19'u kız olduğuna göre erkek öğrenci sayısı kaçtır?",
            "18", "23", "35", "11", "18"));

        Questions.Add(new QuestionTemplate(8, "Fatma, 120 sayfalık bir kitabın 1.gün 36 sayfasını, 2.gün 24 sayfasını okudu. Geriye okumadığı kaç sayfa kaldı?",
            "48", "60", "32", "18", "60"));

        Questions.Add(new QuestionTemplate(9, "84 metrelik yolun 26 metresini yürüyen Zeynep'in yürüyecek kaç metre yolu kalmıştır?",
            "49", "58", "68", "61", "58"));

        Questions.Add(new QuestionTemplate(10, "Bir manav pazara getirdiği 345 kilogram elmasının sabah 132 kilogramını, öğleden sonra da 87 kilogramını sattı. Geriye kaç kilogram elma kalır?",
            "124", "126", "213", "250", "126"));

        Questions.Add(new QuestionTemplate(11, "Bir tren 214 yolcu ile yola çıktı. İlk durakta 86 kişi, ikinci durakta 27 kişi trenden indi. Trende kalan yolcu sayısı kaçtır?",
            "89", "100", "101", "110", "101"));

        Questions.Add(new QuestionTemplate(12, "Kaan 49 misketinin 12 ini kaybetti. Babası ona 24 tane daha misket aldı. Kaan'ın kaç misketi oldu?",
            "67", "54", "61", "49", "61"));

        Questions.Add(new QuestionTemplate(13, "Hülya'nın 47 tane cevizi var. Cevizlerinin 12 tanesini kardeşine, 7 tanesini de ablasına verdi.Hülya'nın kaç tane cevizi kaldı?",
            "17", "28", "33", "26", "28"));

        Questions.Add(new QuestionTemplate(14, "Bir sürahi 12 bardak su ile doluyor. Dolu sürahiden 5 bardak su içildiğinde sürahide kaç bardak su kalır?",
            "3", "5", "7", "9", "7"));

        Questions.Add(new QuestionTemplate(15, "Bir okuldaki 836 öğrencinin 375 tanesi erkek olduğuna göre kaç tane kız öğrenci vardır?",
            "543", "461", "360", "407", "461"));

        Questions.Add(new QuestionTemplate(16, "Ceren’in 91tane fındığı vardı, 70  tanesini yedi. Geriye kaç fındık kaldı?",
            "27", "23", "21", "18", "21"));

        Questions.Add(new QuestionTemplate(17, "Burç 83 sayfalık hikaye kitabının 40sayfasını okudu. Geriye kaç sayfa kaldı?",
            "68", "43", "35", "24", "43"));

        Questions.Add(new QuestionTemplate(18, "Berat 450 sorunun 175 tanesini çözdü. Geriye kaç soru kaldı?",
            "168", "175", "275", "307", "275"));

        Questions.Add(new QuestionTemplate(19, "Berna 603 tane cevizin 284 tanesini yedi. Berna’nın kaç cevizi kaldı?",
            "319", "218", "547", "321", "319"));

        Questions.Add(new QuestionTemplate(20, "Görkem 800 sayfalık hikaye kitabının önce 252, sonra da 191 sayfasını okudu. Geriye kaç sayfa kaldı?",
            "255", "357", "355", "245", "357"));

        Questions.Add(new QuestionTemplate(21, "Bir kasadaki 90 portakalın önce 70 tanesi daha sonra da 13tanesi satılıyor. Kasada kaç tane portakal kalmıştır?",
            "5", "7", "9", "19", "7"));

        Questions.Add(new QuestionTemplate(22, "Bir dalda duran 40 kuşun önce 7, sonra da 17 si uçtu. Dalda kaç kuş kalmıştır?",
            "14", "16", "28", "32", "16"));

        Questions.Add(new QuestionTemplate(23, "630 cevizin 145 tanesini Yaren, 252 tanesini de Bengü yedi. Geriye kaç tane ceviz kaldı?",
            "167", "233", "345", "433", "233"));

        Questions.Add(new QuestionTemplate(24, "450 soruluk bir test kitabında  154 tane matematik ve 172 tane Türkçe sorusu vardır. Geriye kalan Hayat bilgisi sorusu olduğuna göre kaç tane hayat bilgisi sorusu vardır?",
            "72", "74", "124", "127", "124"));

        Questions.Add(new QuestionTemplate(25, "Ahmet’in 79 misketi vardı. Bunlardan 28 tanesini arkadaşı Can’a verdi. Geriye kaç misketi kalmıştır?",
            "51", "43", "61", "72", "51"));

        Questions.Add(new QuestionTemplate(26, "Bir çiftçi tarlasından 350 kg ürün almıştır. Ürünün 50 kilogramı çürümüştür. Geriye kaç kilogram ürün kalmıştır ?",
            "170", "300", "255", "270", "300"));

        Questions.Add(new QuestionTemplate(27, "Bir otobüste 100 yolcu vardır. Birinci durakta 10 kişi, ikinci durakta 15 kişi indiğine göre otobüste kaç yolcu kalmıştır ?",
            "60", "85", "75", "78", "75"));


        Questions.Add(new QuestionTemplate(28, "Sevil 24 yaşındadır kardeşi ondan 9 yaş küçük olduğuna göre kardeşi kaç yaşındadır ?",
            "13", "15", "18", "19", "15"));


        Questions.Add(new QuestionTemplate(29, "Ceyda bayramda 149 şeker toplamıştır. Şekerlerin 30unu dağıtmış 12 sinide yemiştir. Ceyda’nın kaç şekeri kalmıştır ?",
            "100", "103", "107", "117", "107"));


        Questions.Add(new QuestionTemplate(30, "Bir grup öğrenci okul bahçesine 135 fidan dikmiştir. Fidanların 15i kurulduğuna göre kaç fidan kalmıştır ?",
            "79", "97", "119", "120", "120"));


        /*foreach (QuestionTemplate Ques in Questions) 
		{
			//Debug.Log(Ques.Question);
		}*/
        NextButtonClick();
    }
    public void NextScreen()
    {
        //Intestinal_Ad_Load();
        Application.LoadLevel("Title");

    }

    public void NextButtonClick()
    {
        //Debug.Log("=========================              " + Questions.Count);
        transprentLayer.gameObject.SetActive(false);
        //NextButton.gameObject.SetActive(false);
        GameControl.control.ACorrectAnswer = false;
        GameControl.control.BCorrectAnswer = false;
        GameControl.control.CCorrectAnswer = false;
        GameControl.control.DCorrectAnswer = false;
        GameControl.control.AWrongAnswer = false;
        GameControl.control.BWrongAnswer = false;
        GameControl.control.CWrongAnswer = false;
        GameControl.control.DWrongAnswer = false;

        GameControl.control.isACorrect = false;
        GameControl.control.isBCorrect = false;
        GameControl.control.isCCorrect = false;
        GameControl.control.isDCorrect = false;

        AButton.interactable = true;
        BButton.interactable = true;
        CButton.interactable = true;
        DButton.interactable = true;

        QuestionCount = QuestionCount + 1;
        QuestionCountText.text = QuestionCount + "/" + TotalQuestionPerRound;

        if (QuestionCount == TotalQuestionPerRound)
        {
            NextButton.interactable = false;
            NextButton.gameObject.SetActive(false);
            NextSceneButton.gameObject.SetActive(true);
            NextSceneButton.transform.parent.gameObject.SetActive(true);

        }

        ramdomNumber = UnityEngine.Random.Range(0, Questions.Count);
        //Debug.Log("random number =              " + ramdomNumber);
        for (int i = 0; i < Questions.Count; i++)
        {

            if (ramdomNumber == i)
            {
                QuestionField.text = Questions[i].Question;
                OptionAField.text = Questions[i].OptionA;
                OptionBField.text = Questions[i].OptionB;
                OptionCField.text = Questions[i].OptionC;
                OptionDField.text = Questions[i].OptionD;
            }
        }

    }

    void Update()
    {

        ScoreFieldText.text = "#:" + GameControl.control.score;
    }

    public void OptionAButton()
    {
        Correcting();
    }
    public void OptionBButton()
    {
        Correcting();
    }
    public void OptionCButton()
    {
        Correcting();
    }
    public void OptionDButton()
    {
        Correcting();
    }
    void Correcting()
    {
        for (int i = 0; i < Questions.Count; i++)
        {
            if (ramdomNumber == i)
            {

                if (Questions[i].OptionA == Questions[i].CorrectAnswer)
                {
                    GameControl.control.ACorrectAnswer = true;
                    GameControl.control.isACorrect = true;

                }
                else
                {
                    GameControl.control.AWrongAnswer = true;
                    GameControl.control.isACorrect = false;
                }

                if (Questions[i].OptionB == Questions[i].CorrectAnswer)
                {
                    GameControl.control.BCorrectAnswer = true;
                    GameControl.control.isBCorrect = true;
                    //WrongSoundAS.clip = WrongSoundAC;
                    //WrongSoundAS.Play ();
                }
                else
                {
                    GameControl.control.BWrongAnswer = true;
                    GameControl.control.isBCorrect = false;
                }

                if (Questions[i].OptionC == Questions[i].CorrectAnswer)
                {
                    GameControl.control.CCorrectAnswer = true;
                    GameControl.control.isCCorrect = true;
                    //WrongSoundAS.clip = WrongSoundAC;
                    //WrongSoundAS.Play ();
                }
                else
                {
                    GameControl.control.CWrongAnswer = true;
                    GameControl.control.isCCorrect = false;
                }

                if (Questions[i].OptionD == Questions[i].CorrectAnswer)
                {
                    GameControl.control.DCorrectAnswer = true;
                    GameControl.control.isDCorrect = true;
                    //WrongSoundAS.clip = WrongSoundAC;
                    //WrongSoundAS.Play ();
                }
                else
                {
                    GameControl.control.DWrongAnswer = true;
                    GameControl.control.isDCorrect = false;
                }

                RemoveQuestionsAfterDisplay();
            }
        }

    }


    void RemoveQuestionsAfterDisplay()
    {
        transprentLayer.gameObject.SetActive(true);
        NextButton.gameObject.SetActive(true);
        for (int i = 0; i < Questions.Count; i++)
        {
            if (ramdomNumber == i)
            {
                Questions.Remove(Questions[i]);
            }
        }

    }


    //public void Intestinal_Ad_Create()
    //{
    //    InterstitialAd l_interAd = AdmobManager.PrepareInterstitialAd("Interstitial_1");
    //    l_interAd.AdUnitId = "ca-app-pub-6065714673957825/2806333668";
    //    l_interAd.Create();
    //}
    //public void Intestinal_Ad_Load()
    //{
    //    InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
    //    l_interAd.Load();
    //}
    //public void Intestinal_Ad_Show()
    //{
    //    InterstitialAd l_interAd = AdmobManager.Get<InterstitialAd>("Interstitial_1");
    //    l_interAd.Show();
    //}

}

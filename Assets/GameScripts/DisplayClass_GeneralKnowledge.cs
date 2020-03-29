using System.Collections;
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
        NextButton.gameObject.SetActive(false);
        NextSceneButton.transform.parent.gameObject.SetActive(false);

        Questions = new List<QuestionTemplate>();

        Questions.Add(new QuestionTemplate(0, "Ayşe 32, Sema 28 yaşındadır. Ayşe Sema’dan kaç yaş büyüktür?", "4", "13", "14", "24", "4"));

        Questions.Add(new QuestionTemplate(1, "Kırdan 67 papatya topladım. Papatyalardan 13 tanesini anneme, 26 tanesini teyzeme verdim. Geri kalanını da vazoya koyduk. Vazoda kaç çiçek vardır?", "17", "28", "31", "28", "28"));

        Questions.Add(new QuestionTemplate(2, "78 sayfalık kitabın birinci gün 23, ikinci gün 36 sayfasını okudum. Geriye kaç sayfa kaldı?", "8", "19", "23", "36", "19"));

        Questions.Add(new QuestionTemplate(3, "64 sayfalık kitabın birinci gün 21 sayfasını okudum. İkinci gün ise birinci günden 8 sayfa eksik okudum. Geriye okunacak kaç sayfa kaldı?",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(4, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(5, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(6, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(7, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(8, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(9, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(10, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(11, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(12, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(13, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(14, "",
            "", "", "", "", ""));

        Questions.Add(new QuestionTemplate(15, "",
            "", "", "", "", ""));


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
        timeLeft = 10f;
        transprentLayer.gameObject.SetActive(false);
        NextButton.gameObject.SetActive(false);
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
    public Text TimerText;
    public float timeLeft = 10f;

    IEnumerator TimerScript()
    {
        if (QuestionCount == TotalQuestionPerRound + 1)
        {
            NextButton.interactable = false;
            NextButton.gameObject.SetActive(false);
            NextSceneButton.gameObject.SetActive(true);
            timeLeft = -1f;
            NextScreen();
        }
        yield return new WaitForSeconds(1f);
        timeLeft -= Time.deltaTime;
        TimerText.text = Mathf.Round(timeLeft).ToString();
        if (Mathf.Round(timeLeft) == 0)
        {
            NextButtonClick();

            //yield return new WaitForSeconds(1f);
            timeLeft = 10f;
        }

    }

    void Update()
    {

        StartCoroutine("TimerScript");

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

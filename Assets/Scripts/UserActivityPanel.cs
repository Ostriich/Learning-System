using UnityEngine;

public class UserActivityPanel : MonoBehaviour
{
    public GameObject ButtonStart, ButtonStop, ButtonStepByStep, Field;
    public Sprite StartFalse, StartTrue, StopFalse, StopTrue, StepByStepFalse, StepByStepTrue;
    public string TypeOfButton;
    public int TypeOfAlg;

    void Start()
    {
        ButtonStart.GetComponent<SpriteRenderer>().sprite = StartTrue;
        ButtonStop.GetComponent<SpriteRenderer>().sprite = StopFalse;
        ButtonStepByStep.GetComponent<SpriteRenderer>().sprite = StepByStepTrue;
    }

    private void OnMouseDown()
    {
        switch (TypeOfButton)
        {
            case "Start":
                if (TypeOfAlg==0)
                    Field.GetComponent<BubbleSortInfo>().AlgorithmStart();
                else
                    Field.GetComponent<DeikstraInfo>().AllClean();
                Field.GetComponent<StartAlgorithm>().QuickStart = true;
                break;
            case "Stop":
                ButtonStart.GetComponent<SpriteRenderer>().sprite = StartTrue;
                ButtonStop.GetComponent<SpriteRenderer>().sprite = StopFalse;
                ButtonStepByStep.GetComponent<SpriteRenderer>().sprite = StepByStepTrue;
                Field.GetComponent<StartAlgorithm>().Stopped = false;
                if (TypeOfAlg == 0)
                    Field.GetComponent<BubbleSortInfo>().AllClean();
                else
                    Field.GetComponent<DeikstraInfo>().AllClean();
                break;
            case "StepByStep":
                if (!Field.GetComponent<StartAlgorithm>().Stopped)
                {
                    Field.GetComponent<StartAlgorithm>().StepByStep = true;
                    if (TypeOfAlg == 0)
                        Field.GetComponent<BubbleSortInfo>().AlgorithmStart();
                    else
                        Field.GetComponent<DeikstraInfo>().AllClean();
                }
                else
                    Field.GetComponent<StartAlgorithm>().StoppedClick();
                ButtonStart.GetComponent<SpriteRenderer>().sprite = StartFalse;
                ButtonStop.GetComponent<SpriteRenderer>().sprite = StopTrue;
                ButtonStepByStep.GetComponent<SpriteRenderer>().sprite = StepByStepTrue;
                break;
        }
    }
}

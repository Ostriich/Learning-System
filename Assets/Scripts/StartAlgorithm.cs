using UnityEngine;

public class StartAlgorithm : MonoBehaviour
{
    public GameObject[,] AlgorithmPoints = new GameObject[9, 3];
    public GameObject[] AlgorithmFields = new GameObject[10], AlgorithmShine = new GameObject[10], FirstPoints = new GameObject[9], SecondPoints = new GameObject[9], ThirdPoints = new GameObject[9];
    private float wait;
    public int QuickIndex, FieldIndex;
    public bool QuickStart, StepByStep, Stopped;

    void Start()
    {
        QuickStart = false;
        StepByStep = false;
        Stopped = false;
        wait = 0;
        QuickIndex = 100;
    }

    void Update()
    {
        wait += Time.deltaTime;
        if (QuickStart)
        {
            FieldIndex = 0;
            quickStart();
            QuickIndex = 0;
            QuickStart = false;
        }
        if (StepByStep)
        {
            FieldIndex = 0;
            stepByStep();
            StepByStep = false;
        }
        if (wait > 0.025 && QuickIndex!=100)
        {
            quickStart();
        }
    }

    private void quickStart()
    {    
        if (FieldIndex > 1)
            if (FirstPoints[FieldIndex-2].GetComponent<EmptyPointFunctional>().ConnectedBlock)
            {
                if (FirstPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock.GetComponent<PointOfCycle>().PointCheck())
                {
                    FieldIndex++;
                    wait = 0;
                }
                else if (SecondPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock)
                {
                    if (SecondPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock.GetComponent<PointOfCycle>().PointCheck())
                    {
                        FieldIndex++;
                        wait = 0;
                    }
                    else if (ThirdPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock)
                    {
                        if (ThirdPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock.GetComponent<PointOfCycle>().PointCheck())
                        {
                            FieldIndex++;
                            wait = 0;
                        }
                    }
                    else if (AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock)
                    {
                        AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock.GetComponent<GoAction>().StartAction = true;
                        wait = 0;
                        FieldIndex++;
                    }
                    else
                    {
                        QuickIndex = 100;
                    }
                }
                else if (AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock)
                {
                    AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock.GetComponent<GoAction>().StartAction = true;
                    wait = 0;
                    FieldIndex++;
                }
                else
                {
                    QuickIndex = 100;
                }
            } 
            else if (AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock)
            {
                AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock.GetComponent<GoAction>().StartAction = true;
                wait = 0;
                FieldIndex++;
            }
            else
            {
                QuickIndex = 100;
            }
        else if(AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock)
        {
            AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock.GetComponent<GoAction>().StartAction = true;
            wait = 0;
            FieldIndex++;
        }
        else
        {
            QuickIndex = 100;
        }
    }

    private void stepByStep()
    {
        if (FieldIndex > 1)
            if (FirstPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock)
            {
                if (FirstPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock.GetComponent<PointOfCycle>().PointCheck())
                {
                    StoppedClick();
                }
                else if (SecondPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock)
                {
                    if (SecondPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock.GetComponent<PointOfCycle>().PointCheck())
                    {
                        StoppedClick();
                    }
                    else if (ThirdPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock)
                    {
                        if (ThirdPoints[FieldIndex - 2].GetComponent<EmptyPointFunctional>().ConnectedBlock.GetComponent<PointOfCycle>().PointCheck())
                        {
                            StoppedClick();
                        }
                    }
                    else if (AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock)
                    {
                        AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock.GetComponent<GoAction>().StartAction = true;
                        AlgorithmShine[FieldIndex].SetActive(true);
                        Stopped = true;
                    }
                    else
                    {
                        Stopped = false;
                    }
                }
                else if (AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock)
                {
                    AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock.GetComponent<GoAction>().StartAction = true;
                    AlgorithmShine[FieldIndex].SetActive(true);
                    Stopped = true;
                }
                else
                {
                    Stopped = false;
                }
            }
            else if (AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock)
            {
                AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock.GetComponent<GoAction>().StartAction = true;
                AlgorithmShine[FieldIndex].SetActive(true);
                Stopped = true;
            }
            else
            {
                Stopped = false;
            }
        else if (AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock)
        {
            AlgorithmFields[FieldIndex].GetComponent<EmptyBlockFunctional>().ConnectedBlock.GetComponent<GoAction>().StartAction = true;
            AlgorithmShine[FieldIndex].SetActive(true);
            Stopped = true;
        }
        else
        {
            Stopped = false;
        }
    }

    public void StoppedClick()
    {
        AlgorithmShine[FieldIndex].SetActive(false);
        FieldIndex++;
        stepByStep();
    }
}

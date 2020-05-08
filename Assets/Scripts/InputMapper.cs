using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMapper : MonoBehaviour
{
    [Header("Config")]
    public float MaxSquareDistance = 1.5f;
    public float MinSquareDistance = 1.5f;

    [Header("Hand References")]
    public GameObject LeftHand;
    public GameObject RightHand;

    [Header("Indicator References")]
    public GameObject RestingSpotLeft;
    public GameObject RestingSpotRight;

    public GameObject JoySpotLeft;
    public GameObject JoySpotRight;

    public GameObject FearSpotLeft;
    public GameObject FearSpotRight;

    public GameObject SorrowSpotLeft;
    public GameObject SorrowSpotRight;


    void Update()
    {
        float RestingSquareDistance = Mathf.Clamp(
            (LeftHand.transform.localPosition - RestingSpotLeft.transform.localPosition).magnitude *
            (RightHand.transform.localPosition - RestingSpotRight.transform.localPosition).magnitude,
            MinSquareDistance, MaxSquareDistance);

        float JoySquareDistance = Mathf.Clamp(
            (LeftHand.transform.localPosition - JoySpotLeft.transform.localPosition).magnitude *
            (RightHand.transform.localPosition - JoySpotRight.transform.localPosition).magnitude,
            MinSquareDistance, MaxSquareDistance);

        float FearSquareDistance = Mathf.Clamp(
            (LeftHand.transform.localPosition - FearSpotLeft.transform.localPosition).magnitude *
            (RightHand.transform.localPosition - FearSpotRight.transform.localPosition).magnitude,
            MinSquareDistance, MaxSquareDistance);

        float SorrowSquareDistance = Mathf.Clamp(
            (LeftHand.transform.localPosition - SorrowSpotLeft.transform.localPosition).magnitude *
            (RightHand.transform.localPosition - SorrowSpotRight.transform.localPosition).magnitude,
            MinSquareDistance, MaxSquareDistance);

        float sum = RestingSquareDistance + JoySquareDistance + FearSquareDistance + SorrowSquareDistance;
        float pNJoy = sum / JoySquareDistance;
        float pNResting = sum / RestingSquareDistance;
        float pNFear = sum / FearSquareDistance;
        float pNSorrow = sum / SorrowSquareDistance;

        Debug.LogError("Rest = " + pNResting + " | Joy = " + pNJoy + " | Fear = " + pNFear + " | Sorrow = " + pNSorrow);
    }
}

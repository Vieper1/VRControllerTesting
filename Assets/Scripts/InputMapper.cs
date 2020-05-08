using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputMapper : MonoBehaviour
{
    [Header("Config")]
    public float MaxSquareDistance = 1.5f;

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
            0.001f, MaxSquareDistance);

        float JoySquareDistance = Mathf.Clamp(
            (LeftHand.transform.localPosition - JoySpotLeft.transform.localPosition).magnitude *
            (RightHand.transform.localPosition - JoySpotRight.transform.localPosition).magnitude,
            0.001f, MaxSquareDistance);

        float FearSquareDistance = Mathf.Clamp(
            (LeftHand.transform.localPosition - FearSpotLeft.transform.localPosition).magnitude *
            (RightHand.transform.localPosition - FearSpotRight.transform.localPosition).magnitude,
            0.001f, MaxSquareDistance);

        float SorrowSquareDistance = Mathf.Clamp(
            (LeftHand.transform.localPosition - SorrowSpotLeft.transform.localPosition).magnitude *
            (RightHand.transform.localPosition - SorrowSpotRight.transform.localPosition).magnitude,
            0.001f, MaxSquareDistance);

        Debug.LogError("Rest = " + RestingSquareDistance + " | Joy = " + JoySquareDistance + " | Fear = " + FearSquareDistance + " | Sorrow = " + SorrowSquareDistance);
    }
}

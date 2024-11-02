using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARPlacementPrefabSwitcherButtons : MonoBehaviour
{
    [SerializeField] private GameObject prefab1;
    [SerializeField] private GameObject prefab2;
    [SerializeField] private GameObject prefab3;
    public ARPlacementInteractable arPlacementInteractable;

    public void SetPlacementPrefab1()
    {
        arPlacementInteractable.placementPrefab = prefab1;
    }

    public void SetPlacementPrefab2()
    {
        arPlacementInteractable.placementPrefab = prefab2;
    }

    public void SetPlacementPrefab3()
    {
        arPlacementInteractable.placementPrefab = prefab3;
    }
}

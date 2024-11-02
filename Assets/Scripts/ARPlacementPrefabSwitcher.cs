using System.Collections;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARPlacementPrefabSwitcher : MonoBehaviour
{
    public GameObject[] prefabs;
    private ARPlacementInteractable arPlacementInteractable;
    private int currentPrefabIndex = 0;

    private void Awake()
    {
        arPlacementInteractable = GetComponent<ARPlacementInteractable>();
        if (arPlacementInteractable == null) return;
        StartCoroutine(SwitchPrefabEveryThreeSeconds());
    }

    private IEnumerator SwitchPrefabEveryThreeSeconds()
    {
        while (true)
        {
            arPlacementInteractable.placementPrefab = prefabs[currentPrefabIndex];
            currentPrefabIndex = (currentPrefabIndex + 1) % prefabs.Length;
            yield return new WaitForSeconds(3);
        }
    }
}

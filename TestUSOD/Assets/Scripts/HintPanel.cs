using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HintPanel : MonoBehaviour
{
    private Animator showHideAnimation;
    private RectTransform panelRectTransform;
    private int maxElementsPerRow;
    private GridLayoutGroup gridLayout;

    [SerializeField] Image image;
    [SerializeField] TMP_Text text;

    private void Start()
    {
        showHideAnimation = GetComponent<Animator>();
        gridLayout = GetComponentInChildren<GridLayoutGroup>();
        panelRectTransform = GetComponentInChildren<RectTransform>();
    }

    public void ShowPanel()
    {
        showHideAnimation.SetBool("isPanelOpen", true);
    }
    public void HidePanel()
    {
        showHideAnimation.SetBool("isPanelOpen", false);
    }

    public void AdjustSizeBasedOnContent()
    {
        if (gridLayout != null)
        {
            int childCount = gridLayout.transform.childCount;
            int rowCount = Mathf.CeilToInt((float)childCount / maxElementsPerRow);
            
            // Розмір елемента у гріді
            Vector2 cellSize = gridLayout.cellSize;

            // Розмір панелі з урахуванням кількості рядів та елементів в ряду
            Vector2 newSize = new Vector2(cellSize.x * Mathf.Min(maxElementsPerRow, childCount), cellSize.y * rowCount);

            // Змінюємо розмір панелі
            panelRectTransform.sizeDelta = newSize;
        }
    }
}

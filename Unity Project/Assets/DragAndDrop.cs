using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler
{
    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        // Do nothing
    }

    public void OnDrag(PointerEventData eventData)
    {
        Vector2 anchoredPosition;
        if (RectTransformUtility.ScreenPointToLocalPointInRectangle(rectTransform, eventData.position, eventData.pressEventCamera, out anchoredPosition))
        {
            rectTransform.anchoredPosition += anchoredPosition - (Vector2)rectTransform.position;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Actions when button is released (if any)
    }
}
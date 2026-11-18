using UnityEngine;

/// <summary>
/// フロントボタン
/// 
/// 説明スライドを前に戻すボタン
/// </summary>
public class FrontButton : ButtonBase
{
    [SerializeField] private ExplanationManager explanationManager; // ゲーム説明マネージャー
    [SerializeField] private ExplanationButtonManager explanationButtonManager; // 説明ボタンマネージャー

    public override void OnClick()
    {
        base.OnClick();
        explanationManager.BackExplanation();
        explanationButtonManager.ManageButton();
    }
}

using UnityEngine;

/// <summary>
/// ネクストボタン
/// 
/// 説明スライドを進めるボタン
/// </summary>
public class NextButton : ButtonBase
{
    [SerializeField] private ExplanationManager explanationManager; // ゲーム説明マネージャー
    [SerializeField] private ExplanationButtonManager explanationButtonManager; // 説明ボタンマネージャー

    public override void OnClick()
    {
        base.OnClick();
        explanationManager.NextExplanation();
        explanationButtonManager.ManageButton();
    }
}

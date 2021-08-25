using Assets.Scripts;
using Assets.Scripts.Data;
using UnityEngine;

public class CreatureCard : Card, ICard
{
    [SerializeField] private Token _amberToken;
    [SerializeField] private Token _damageToken;
    [SerializeField] private Token _powerToken;
    [SerializeField] private Token _stunToken;
    [SerializeField] private Token _enrageToken;
    [SerializeField] private Token _wardToken;

    public CardType Type => CardType.CREATURE;

    private CreatureCardData _data= new CreatureCardData();

    public void SetAmber(int amount)
    {
        _amberToken.SetAmount(amount);
        _amberToken.gameObject.SetActive(amount > 0);
        _data.Amber = amount;
    }

    public void SetDamage(int amount)
    {
        _damageToken.SetAmount(amount);
        _damageToken.gameObject.SetActive(amount > 0);
    }

    public void SetPower(int amount)
    {
        _powerToken.SetAmount(amount);
        _powerToken.gameObject.SetActive(amount > 0);
    }

    public void SetStun(bool active)
    {
        _stunToken.gameObject.SetActive(active);
    }

    public void SetEnrage(bool active)
    {
        _stunToken.gameObject.SetActive(active);
    }

    public void SenWard(bool active)
    {
        _stunToken.gameObject.SetActive(active);
    }
}

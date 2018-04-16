using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBAbstractFactory3
{
    /// <summary>
    /// 'AbstractFactory'
    /// </summary>
    abstract class FabricanteAutomoveis
    {
        public abstract Motor CriarMotor();
        public abstract Chassi CriarChassi();
    }

    //========================================================================

    /// <summary>
    /// 'ConcreteFactory1'
    /// </summary>
    class Fiat : FabricanteAutomoveis
    {
        public override Motor CriarMotor()
        {
            return new MotorFiat();
        }
        public override Chassi CriarChassi()
        {
            return new ChassiFiat();
        }
    }

    /// <summary>
    /// 'ConcreteFactory2'
    /// </summary>
    class Volks : FabricanteAutomoveis
    {
        public override Motor CriarMotor()
        {
            return new MotorVolks();
        }
        public override Chassi CriarChassi()
        {
            return new ChassiVolks();
        }
    }

    //========================================================================

    /// <summary>
    /// 'AbstractProductA'
    /// </summary>
    abstract class Motor
    {

    }

    /// <summary>
    /// 'AbstractProductB'
    /// </summary>
    abstract class Chassi
    {
        public abstract void RecebeMotor(Motor h);
    }

    //========================================================================

    /// <summary>
    /// 'ProductA1'
    /// </summary>
    class MotorFiat : Motor
    {

    }

    /// <summary>
    /// 'ProductB1'
    /// </summary>
    class ChassiFiat : Chassi
    {
        public override void RecebeMotor(Motor motor)
        {
            Console.WriteLine(this.GetType().Name + " recebe " + motor.GetType().Name);
        }
    }
    
    /// <summary>
    /// 'ProductA2'
    /// </summary>
    class MotorVolks : Motor
    {

    }

    /// <summary>
    /// 'ProductB2'
    /// </summary>
    class ChassiVolks : Chassi
    {
        public override void RecebeMotor(Motor motor)
        {
            Console.WriteLine(this.GetType().Name + " recebe " + motor.GetType().Name);
        }
    }

    //========================================================================

    /// <summary>
    /// 'Client'
    /// </summary>
    class Montadora
    {
        private Motor _motor;
        private Chassi _chassi;

        // Construtor
        public Montadora(FabricanteAutomoveis fabrica)
        {
            _chassi = fabrica.CriarChassi();
            _motor = fabrica.CriarMotor();
        }

        public void MontarChassi()
        {
            _chassi.RecebeMotor(_motor);
        }
    }
}


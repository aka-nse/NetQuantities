namespace NetQuantities;

public class UnitCalculationsTest
{
    [Fact]
    public void Test()
    {
#pragma warning disable IDE1006
        var a_ = QAcceleration.FromMetrePerSquareSecond(1);
        var É∆ = QAngle.FromRadian(1);
        var É÷ = QAngularVelocity.FromRadianPerSecond(1);
        var Éø = QAngularAcceleration.FromRadianPerSquareSecond(1);
        var S_ = QArea.FromMetre2(1);
        var ac = QCatalyticActivity.FromKatal(1);
        var Éœ = QDensity.FromKilogramPerCubicMetre(1);
        var _1 = QDimensionless.FromRaw(1);
        var Ce = QElectricCapacity.FromFarad(1);
        var Qe = QElectricCharge.FromCoulomb(1);
        var Ge = QElectricConductance.FromSiemens(1);
        var É» = QElectricConductivity.FromSiemensPerMetre(1);
        var Ie = QElectricCurrent.FromAmpere(1);
        var Ee = QElectricFieldStrength.FromVoltPerMetre(1);
        var Re = QElectricResistance.FromOhm(1);
        var Ve = QElectricVoltage.FromVolt(1);
        var U_ = QEnergy.FromJoule(1);
        var F_ = QForce.FromNewton(1);
        var f_ = QFrequency.FromHertz(1);
        var Ch = QHeatCapacity.FromJoulePerKelvin(1);
        var x_ = QLength.FromMetre(1);
        var L_ = QLuminance.FromCandelaPerSquareMetre(1);
        var Iv = QLuminousIntensity.FromCandela(1);
        var m_ = QMass.FromKilogram(1);
        var P_ = QPower.FromWatt(1);
        var p_ = QPressure.FromPascal(1);
        var n_ = QSubstanceAmount.FromMole(1);
        var T_ = QTemperature.FromKelvin(1);
        var t_ = QTime.FromSecond(1);
        var v_ = QVelocity.FromMetrePerSecond(1);
        var vo = QVolume.FromCubicMetre(1);

        Assert.Equal(É∆, É÷ * t_);
        Assert.Equal(É÷, Éø * t_);
        Assert.Equal(S_, x_ * x_);
        Assert.Equal(_1, t_ * f_);
        Assert.Equal(_1, Re * Ge);
        Assert.Equal(v_, a_ * t_);
        Assert.Equal(Qe, Ie * t_);
        Assert.Equal(Qe, Ce * Ve);
        Assert.Equal(Ge, É» * x_);
        Assert.Equal(Ve, Ee * x_);
        Assert.Equal(Ve, Ie * Re);
        Assert.Equal(Iv, L_ * S_);
        Assert.Equal(m_, Éœ * vo);
        Assert.Equal(U_, P_ * t_);
        Assert.Equal(U_, F_ * x_);
        Assert.Equal(U_, Ch * T_);
        Assert.Equal(F_, m_ * a_);
        Assert.Equal(F_, p_ * S_);
        Assert.Equal(n_, ac * t_);
        Assert.Equal(vo, S_ * x_);
    }
}
using Business.Abstract;
using DataAccsess.Abstract;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CarManager : ICarManager
{
    ICarDal _carDal;

    public CarManager(ICarDal carDal)
    {
        _carDal = carDal;
    }

    public List<Car> Add(Car car)
    {
        throw new NotImplementedException();
    }


    //ADO.NET = veri tabanına bağlanmamızı sağlayan, veri tabanını kontrol etmemizi sağllayan, veri tabanına sorgu yazmamızı
    //sağlayan bir kütüphanedir . bu kütüphane vasıtasıyla verilerimizi listeleyebilir, yeni veri ekleyebilir, güncelliyebiliriz
    //ama günümüzde bununla yazdığımız kodlar zordur onun yerine :ilişkiyi kolaylaştırmak ve sağlamak(ENTİTY FRAMEWORK)için
    //çeşitli ORM - dediğimiz yapıları kullanırız 

    //ORM - Object relational mapping = Nesnelerin veri tabanı ile bağdaştırılması
    //alternatifleri = NHibernate
    //Dapper  = aslında bir orm değil ado.netkolaylaştırılmış versiyonudur

    public List<Car> GetAll()
    {
        return _carDal.GetAll();
    }

    public List<Car> GetCarsBylBrandId(int id)
    {
        return _carDal.GetAll(c=>c.BrandId == id);
    }

    public List<Car> GetCarsBylColorId(int id)
    {
        return _carDal.GetAll(p=> p.ColorId == id);
    }
}

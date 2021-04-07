using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(CarImage carImages, IFormFile formFile);
        IResult Delete(CarImage carImages);
        IResult Update(CarImage carImages, IFormFile formFile);
        IDataResult<List<CarImage>> GetAll();
        IDataResult<CarImage> GetImage(int imageId);
        IDataResult<List<CarImage>> GetImagesByCarId(int carId);

    }
}

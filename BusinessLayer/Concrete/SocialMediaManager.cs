﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class SocialMediaManager : ISocialMediaService
	{
		private readonly ISocialMediaDal _socialMediaDal;

		public SocialMediaManager(ISocialMediaDal socialMediaDal)
		{
			_socialMediaDal = socialMediaDal;
		}

		public void TAdd(SocialMedia t)
		{
			_socialMediaDal.Add(t);
		}

		public void TDelete(SocialMedia t)
		{
			_socialMediaDal.Delete(t);
		}

		public SocialMedia TGetById(int id)
		{
			return _socialMediaDal.GetById(id);
		}

		public List<SocialMedia> TGetListAll()
		{
			return _socialMediaDal.GetListAll();
		}

		public void TUpdate(SocialMedia t)
		{
			_socialMediaDal.Update(t);
		}
	}
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.RS_2
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// РазрешНаСтроит.
    /// </summary>
    //  *** Start programmer edit section *** (РазрешНаСтроит CustomAttributes)

    //  *** End programmer edit section *** (РазрешНаСтроит CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    public class РазрешНаСтроит : ICSSoft.STORMNET.DataObject
    {
        
        private string fНаименование;
        
        private IIS.RS_2.tВидРазрешения fВидРазрешения;
        
        private bool fАрхив;
        
        private System.DateTime fДатаРазрешения;
        
        private int fНомерРазрешения;
        
        private IIS.RS_2.DetailArrayOfОбъектСтроит fОбъектСтроит;
        
        private IIS.RS_2.DetailArrayOfЗастройщик fЗастройщик;
        
        //  *** Start programmer edit section *** (РазрешНаСтроит CustomMembers)

        //  *** End programmer edit section *** (РазрешНаСтроит CustomMembers)

        
        /// <summary>
        /// Наименование.
        /// </summary>
        //  *** Start programmer edit section *** (РазрешНаСтроит.Наименование CustomAttributes)

        //  *** End programmer edit section *** (РазрешНаСтроит.Наименование CustomAttributes)
        [StrLen(255)]
        public virtual string Наименование
        {
            get
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.Наименование Get start)

                //  *** End programmer edit section *** (РазрешНаСтроит.Наименование Get start)
                string result = this.fНаименование;
                //  *** Start programmer edit section *** (РазрешНаСтроит.Наименование Get end)

                //  *** End programmer edit section *** (РазрешНаСтроит.Наименование Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.Наименование Set start)

                //  *** End programmer edit section *** (РазрешНаСтроит.Наименование Set start)
                this.fНаименование = value;
                //  *** Start programmer edit section *** (РазрешНаСтроит.Наименование Set end)

                //  *** End programmer edit section *** (РазрешНаСтроит.Наименование Set end)
            }
        }
        
        /// <summary>
        /// ВидРазрешения.
        /// </summary>
        //  *** Start programmer edit section *** (РазрешНаСтроит.ВидРазрешения CustomAttributes)

        //  *** End programmer edit section *** (РазрешНаСтроит.ВидРазрешения CustomAttributes)
        public virtual IIS.RS_2.tВидРазрешения ВидРазрешения
        {
            get
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.ВидРазрешения Get start)

                //  *** End programmer edit section *** (РазрешНаСтроит.ВидРазрешения Get start)
                IIS.RS_2.tВидРазрешения result = this.fВидРазрешения;
                //  *** Start programmer edit section *** (РазрешНаСтроит.ВидРазрешения Get end)

                //  *** End programmer edit section *** (РазрешНаСтроит.ВидРазрешения Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.ВидРазрешения Set start)

                //  *** End programmer edit section *** (РазрешНаСтроит.ВидРазрешения Set start)
                this.fВидРазрешения = value;
                //  *** Start programmer edit section *** (РазрешНаСтроит.ВидРазрешения Set end)

                //  *** End programmer edit section *** (РазрешНаСтроит.ВидРазрешения Set end)
            }
        }
        
        /// <summary>
        /// Архив.
        /// </summary>
        //  *** Start programmer edit section *** (РазрешНаСтроит.Архив CustomAttributes)

        //  *** End programmer edit section *** (РазрешНаСтроит.Архив CustomAttributes)
        public virtual bool Архив
        {
            get
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.Архив Get start)

                //  *** End programmer edit section *** (РазрешНаСтроит.Архив Get start)
                bool result = this.fАрхив;
                //  *** Start programmer edit section *** (РазрешНаСтроит.Архив Get end)

                //  *** End programmer edit section *** (РазрешНаСтроит.Архив Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.Архив Set start)

                //  *** End programmer edit section *** (РазрешНаСтроит.Архив Set start)
                this.fАрхив = value;
                //  *** Start programmer edit section *** (РазрешНаСтроит.Архив Set end)

                //  *** End programmer edit section *** (РазрешНаСтроит.Архив Set end)
            }
        }
        
        /// <summary>
        /// ДатаРазрешения.
        /// </summary>
        //  *** Start programmer edit section *** (РазрешНаСтроит.ДатаРазрешения CustomAttributes)

        //  *** End programmer edit section *** (РазрешНаСтроит.ДатаРазрешения CustomAttributes)
        public virtual System.DateTime ДатаРазрешения
        {
            get
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.ДатаРазрешения Get start)

                //  *** End programmer edit section *** (РазрешНаСтроит.ДатаРазрешения Get start)
                System.DateTime result = this.fДатаРазрешения;
                //  *** Start programmer edit section *** (РазрешНаСтроит.ДатаРазрешения Get end)

                //  *** End programmer edit section *** (РазрешНаСтроит.ДатаРазрешения Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.ДатаРазрешения Set start)

                //  *** End programmer edit section *** (РазрешНаСтроит.ДатаРазрешения Set start)
                this.fДатаРазрешения = value;
                //  *** Start programmer edit section *** (РазрешНаСтроит.ДатаРазрешения Set end)

                //  *** End programmer edit section *** (РазрешНаСтроит.ДатаРазрешения Set end)
            }
        }
        
        /// <summary>
        /// НомерРазрешения.
        /// </summary>
        //  *** Start programmer edit section *** (РазрешНаСтроит.НомерРазрешения CustomAttributes)

        //  *** End programmer edit section *** (РазрешНаСтроит.НомерРазрешения CustomAttributes)
        public virtual int НомерРазрешения
        {
            get
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.НомерРазрешения Get start)

                //  *** End programmer edit section *** (РазрешНаСтроит.НомерРазрешения Get start)
                int result = this.fНомерРазрешения;
                //  *** Start programmer edit section *** (РазрешНаСтроит.НомерРазрешения Get end)

                //  *** End programmer edit section *** (РазрешНаСтроит.НомерРазрешения Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.НомерРазрешения Set start)

                //  *** End programmer edit section *** (РазрешНаСтроит.НомерРазрешения Set start)
                this.fНомерРазрешения = value;
                //  *** Start programmer edit section *** (РазрешНаСтроит.НомерРазрешения Set end)

                //  *** End programmer edit section *** (РазрешНаСтроит.НомерРазрешения Set end)
            }
        }
        
        /// <summary>
        /// РазрешНаСтроит.
        /// </summary>
        //  *** Start programmer edit section *** (РазрешНаСтроит.ОбъектСтроит CustomAttributes)

        //  *** End programmer edit section *** (РазрешНаСтроит.ОбъектСтроит CustomAttributes)
        public virtual IIS.RS_2.DetailArrayOfОбъектСтроит ОбъектСтроит
        {
            get
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.ОбъектСтроит Get start)

                //  *** End programmer edit section *** (РазрешНаСтроит.ОбъектСтроит Get start)
                if ((this.fОбъектСтроит == null))
                {
                    this.fОбъектСтроит = new IIS.RS_2.DetailArrayOfОбъектСтроит(this);
                }
                IIS.RS_2.DetailArrayOfОбъектСтроит result = this.fОбъектСтроит;
                //  *** Start programmer edit section *** (РазрешНаСтроит.ОбъектСтроит Get end)

                //  *** End programmer edit section *** (РазрешНаСтроит.ОбъектСтроит Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.ОбъектСтроит Set start)

                //  *** End programmer edit section *** (РазрешНаСтроит.ОбъектСтроит Set start)
                this.fОбъектСтроит = value;
                //  *** Start programmer edit section *** (РазрешНаСтроит.ОбъектСтроит Set end)

                //  *** End programmer edit section *** (РазрешНаСтроит.ОбъектСтроит Set end)
            }
        }
        
        /// <summary>
        /// РазрешНаСтроит.
        /// </summary>
        //  *** Start programmer edit section *** (РазрешНаСтроит.Застройщик CustomAttributes)

        //  *** End programmer edit section *** (РазрешНаСтроит.Застройщик CustomAttributes)
        public virtual IIS.RS_2.DetailArrayOfЗастройщик Застройщик
        {
            get
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.Застройщик Get start)

                //  *** End programmer edit section *** (РазрешНаСтроит.Застройщик Get start)
                if ((this.fЗастройщик == null))
                {
                    this.fЗастройщик = new IIS.RS_2.DetailArrayOfЗастройщик(this);
                }
                IIS.RS_2.DetailArrayOfЗастройщик result = this.fЗастройщик;
                //  *** Start programmer edit section *** (РазрешНаСтроит.Застройщик Get end)

                //  *** End programmer edit section *** (РазрешНаСтроит.Застройщик Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (РазрешНаСтроит.Застройщик Set start)

                //  *** End programmer edit section *** (РазрешНаСтроит.Застройщик Set start)
                this.fЗастройщик = value;
                //  *** Start programmer edit section *** (РазрешНаСтроит.Застройщик Set end)

                //  *** End programmer edit section *** (РазрешНаСтроит.Застройщик Set end)
            }
        }
    }
}

/*
 * Medical managment API
 *
 * Medical managment API for hospital staff and treatments managment
 *
 * OpenAPI spec version: 1.0.0
 * Contact: matej.mikus96@gmail.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Eu.InCloud.Medical.Management.Models;

namespace Eu.InCloud.Medical.Management.Dtos
{ 
    public class TreatmentDto 
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
        public SimpleEmployee MainDoctorObject { get; set; }
        public List<SimpleEmployee> OtherDoctorsObject { get; set; }
        public string RoomNumber { get; set; }
        public DateTime? Date { get; set; }
        public int Status { get; set; }

        public static 
        Treatment ConvertToTreatmentModel(TreatmentDto treatmentDto) {
            var treatment = new Treatment {
                Id = treatmentDto.Id,
                Title = treatmentDto.Title,
                Type = treatmentDto.Type,
                Description = treatmentDto.Description,
                MainDoctorId = treatmentDto.MainDoctorObject.Id,
                OtherDoctorsId = treatmentDto.OtherDoctorsObject.Select(x => x.Id).ToList(),
                Date = treatmentDto.Date,
                Status = treatmentDto.Status,
                RoomNumber = treatmentDto.RoomNumber
            };
            return treatment;
        }
    }
}
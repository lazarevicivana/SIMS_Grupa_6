// File:    PatientService.cs
// Author:  dZoNi
// Created: Thursday, April 7, 2022 18:12:03
// Purpose: Definition of Class PatientService

using Model;
using Repository;
using System.Collections.Generic;

namespace Service
{
    public class PatientService
    {
        private PatientRepository pr = new PatientRepository();
        public Patient FindPatientById(int id)
        {
            return pr.FindById(id);
        }

        public List<Patient> FindAllPatients()
        {
            return pr.FindAll();
        }

        public bool DeletePatientById(int id)
        {
            pr.DeleteById(id);
            return true;
        }

        public bool AddPatient(Patient p)
        {
            pr.Create(p);
            return true;
        }

        public bool AddGuestPatient(Patient p)
        {
            pr.Create(p);
            return true;
        }

        public bool UpdatePatient(Patient p)
        {
            pr.Update(p);
            return true;
        }

        public Repository.PatientRepository patientRepository;

    }
}
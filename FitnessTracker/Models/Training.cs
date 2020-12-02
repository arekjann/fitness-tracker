﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FitnessTracker.Models
{

    public class Training
    {

        [Key]
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        [DefaultValue(true)]
        public bool IsPublic { get; set; }

        [MaxLength(1000)]
        public string Description { get; set; }

        public virtual ICollection<ExerciseTraining> ExerciseTraining { get; set; }

    }

}
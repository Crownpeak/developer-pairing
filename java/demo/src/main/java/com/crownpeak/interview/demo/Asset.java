package com.crownpeak.interview.demo;


import org.springframework.format.annotation.DateTimeFormat;

import java.time.LocalDateTime;

public class Asset {
    public Integer id;
    public String name;
    public String dateCreatedUTC;
    public String createdBy;
    public String dateModifiedUTC;
    public String modifiedBy;
    public Boolean isDeleted;

}

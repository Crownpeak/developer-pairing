package com.crownpeak.interview.demo;

import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import java.awt.*;
import java.time.LocalDateTime;
import java.time.ZonedDateTime;
import java.time.format.DateTimeFormatter;

@RequestMapping("/api/assets")
@RestController
public class AssetsController {
    @CrossOrigin(value = "localhost:3000")
    @RequestMapping(value = "", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public Asset[] index() {
        Asset asset = new Asset();
        asset.id = 1;
        asset.name = "Keji";
        asset.dateCreatedUTC = ZonedDateTime.now().format(DateTimeFormatter.ISO_OFFSET_DATE_TIME);
        asset.createdBy = "00000000-0000-0000-0000-000000000000";
        asset.dateModifiedUTC = ZonedDateTime.now().format(DateTimeFormatter.ISO_OFFSET_DATE_TIME);
        asset.modifiedBy = "00000000-0000-0000-0000-000000000000";
        asset.isDeleted = false;
        Asset[] assets = new Asset[1];
        assets[0] = asset;
        return assets;
    }

    @RequestMapping(value = "/{assetId}", method = RequestMethod.GET, produces = {MediaType.APPLICATION_JSON_VALUE})
    public Asset get(@PathVariable Integer assetId) {
        Asset asset = new Asset();
        asset.id = assetId;
        asset.name = "Keji";
        asset.dateCreatedUTC = ZonedDateTime.now().format(DateTimeFormatter.ISO_OFFSET_DATE_TIME);
        asset.createdBy = "00000000-0000-0000-0000-000000000000";
        asset.dateModifiedUTC = ZonedDateTime.now().format(DateTimeFormatter.ISO_OFFSET_DATE_TIME);
        asset.modifiedBy = "00000000-0000-0000-0000-000000000000";
        asset.isDeleted = false;
        return asset;
    }
}
